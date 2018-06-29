﻿using System.Collections.Generic;
using CorpusExplorer.Sdk.Model.Adapter.Corpus.Abstract;
using CorpusExplorer.Sdk.Utils.DocumentProcessing.Abstract;
using CorpusExplorer.Sdk.Utils.DocumentProcessing.Abstract.Model.Abstract;
using CorpusExplorer.Sdk.Utils.DocumentProcessing.Builder;

namespace CorpusExplorer.Sdk.Utils.DocumentProcessing.Tagger.Abstract
{
  public abstract class AbstractAdditionalTagger :
    AbstractDocumentProcessingStepFull<AbstractCorpusAdapter, AbstractCorpusAdapter>
  {
    public AbstractCorpusBuilder CorpusBuilder { get; set; } = new CorpusBuilderWriteDirect();

    public string ModelPath { get; set; }

    public override void Execute()
    {
      Initialize();

      while (Input.Count > 0)
      {
        AbstractCorpusAdapter corpus;
        if (!Input.TryDequeue(out corpus))
          continue;

        CorpusBuilder.Append(corpus, ExecuteCall(ref corpus));
      }

      Cleanup();
    }

    protected abstract void Cleanup();

    /// <summary>
    ///   Muss vom AdditionalTagger implementiert werden.
    /// </summary>
    /// <param name="corpus">
    ///   Das Originalkorpus wird als Referenz übergeben, um Daten zu sparen UND die Möglichkeit zu schaffen, Metadaten zu
    ///   verändern.
    ///   Bitte nutzen Sie die Referenz NICHT zur Dokument-/Layerwert-Manipulation. Vernden Sie stattdessen den return-Value
    /// </param>
    /// <returns>Gibt die neuen Layer aus, die an das Korpus angefügt werden sollten.</returns>
    protected abstract IEnumerable<AbstractLayerState> ExecuteCall(ref AbstractCorpusAdapter corpus);

    protected abstract void Initialize();
  }
}