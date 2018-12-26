using System.Collections.Generic;
using System.Linq;
using CorpusExplorer.Sdk.Blocks.SelectionCluster.Cluster.Abstract;
using CorpusExplorer.Sdk.Model;

namespace CorpusExplorer.Sdk.Blocks.SelectionCluster.Generator.Abstract
{
  public abstract class AbstractSelectionClusterGeneratorValue : AbstractSelectionClusterGenerator
  {
    public override AbstractCluster[] AutoGenerate(Selection selection)
    {
      var res = new Dictionary<string, AbstractCluster>();
      foreach (var doc in selection.DocumentMetadata)
        try
        {
          if (doc.Value == null)
            continue;

          var val = PreFixClusterValue(doc.Value.ContainsKey(MetadataKey) ? doc.Value[MetadataKey] : null);
          var key = GenerateKey(val);

          if (!res.ContainsKey(key))
            res.Add(key, NewCluster(val));
        }
        catch
        {
          // ignore
        }

      return res.Select(x => x.Value).ToArray();
    }

    /// <summary>
    /// Bereinigt einen Cluster-Wert bevor dieser an GenerateKey/NewCluster �bergeben wird.
    /// </summary>
    /// <param name="value">Cluster-Wert</param>
    /// <returns>Bereinigter Cluster-Wert</returns>
    protected virtual object PreFixClusterValue(object value) => value;

    /// <summary>
    /// Erzeugt aus einem Cluster-Wert einen eindeutigen Schl�ssel
    /// </summary>
    /// <param name="value">ClusterWert</param>
    /// <returns></returns>
    protected abstract string GenerateKey(object value);

    /// <summary>
    /// Erzeugt ein neues Cluster
    /// </summary>
    /// <param name="value">Cluster-Wert</param>
    /// <returns>Cluster</returns>
    protected abstract AbstractCluster NewCluster(object value);
  }
}