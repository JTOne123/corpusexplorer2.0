#region

using System.Collections.Generic;

#endregion

namespace CorpusExplorer.Sdk.ViewModel.Interfaces
{
  public interface IProvideAggregatedDataItems
  {
    /// <summary>
    ///   Gebe eine aggregiertes Ergebnis des abgefragten Levels zur�ck.
    ///   Wenn null, dann gebe das aggregierte Ergebnis des Root-Levels zur�ck.
    /// </summary>
    /// <param name="level">Level</param>
    /// <returns>Wenn null, dann exsistieren auf diesem Level keine Items mehr die aggregiert werden k�nnten.</returns>
    double? GetAggregatedValue(params string[] level);

    /// <summary>
    ///   Gibt die Items des abgefragen Levels zur�ck.
    ///   Wenn null dann gebe die Items des Root-Levels zur�ck.
    /// </summary>
    /// <param name="level">Level</param>
    /// <returns>Wenn Level dann gibt es auf diesem Level keine Items mehr</returns>
    IEnumerable<string> GetItems(params string[] level);
  }
}