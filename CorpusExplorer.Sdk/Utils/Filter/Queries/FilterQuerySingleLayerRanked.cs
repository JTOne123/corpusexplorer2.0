﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using CorpusExplorer.Sdk.Model.Adapter.Corpus.Abstract;
using CorpusExplorer.Sdk.Utils.Filter.Abstract;

namespace CorpusExplorer.Sdk.Utils.Filter.Queries
{
  [XmlRoot]
  [Serializable]
  public class FilterQuerySingleLayerRanked : AbstractFilterQuery
  {
    [XmlArray]
    public Dictionary<string, double> Expressions = new Dictionary<string, double>();

    [XmlIgnore] 
    private object _queriesLock = new object();

    [XmlIgnore] 
    private List<KeyValuePair<AbstractFilterQuery, double>> _queries = null;

    [XmlIgnore]
    private List<KeyValuePair<AbstractFilterQuery, double>> Queries
    {
      get
      {
        lock (_queriesLock)
        {
          if (_queries != null)
            return _queries;

          _queries = new List<KeyValuePair<AbstractFilterQuery, double>>();
          foreach (var expression in Expressions)
            _queries.Add(
              new KeyValuePair<AbstractFilterQuery, double>(QueryParser.Parse(expression.Key), expression.Value));
          return _queries;
        }
      }
    }

    public override object Clone()
    {
      return new FilterQuerySingleLayerRanked
      {
        Inverse = Inverse,
        Expressions = Expressions.ToDictionary(x => x.Key, x => x.Value),
        OrFilterQueries = OrFilterQueries.Select(q => q.Clone() as AbstractFilterQuery)
      };
    }

    [XmlIgnore]
    public override string Verbal => "Bewerteter Filterausdruck";

    protected override int GetSentenceFirstIndexCall(AbstractCorpusAdapter corpus, Guid documentGuid, int sentence)
    {
      return GetWordIndices(corpus, documentGuid, sentence).Min();
    }

    protected override IEnumerable<int> GetSentencesCall(AbstractCorpusAdapter corpus, Guid documentGuid)
    {
      var res = new Dictionary<int, double>();
      foreach (var query in Queries)
      {
        var indices = query.Key.GetSentenceIndices(corpus, documentGuid);
        foreach (var index in indices)
        {
          if (res.ContainsKey(index))
            res[index] += query.Value;
          else
            res.Add(index, query.Value);
        }
      }

      return res.Where(x => x.Value >= 1).Select(x => x.Key);
    }

    public override IEnumerable<int> GetWordIndices(AbstractCorpusAdapter corpus, Guid documentGuid, int sentence)
    {
      var res = new Dictionary<int, double>();
      foreach (var query in Queries)
      {
        var indices = query.Key.GetWordIndices(corpus, documentGuid, sentence);
        foreach (var index in indices)
        {
          if (res.ContainsKey(index))
            res[index] += query.Value;
          else
            res.Add(index, query.Value);
        }
      }

      return res.Where(x => x.Value >= 1).Select(x => x.Key);
    }

    protected override bool ValidateCall(AbstractCorpusAdapter corpus, Guid documentGuid)
    {
      var sum = 0d;
      foreach (var query in Queries)
      {
        if(query.Key.Validate(corpus, documentGuid))
          sum += query.Value;
      }

      return sum >= 1;
    }
  }
}