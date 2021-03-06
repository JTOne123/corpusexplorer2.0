using CorpusExplorer.Sdk.EchtzeitEngine.Calculator.Step.Abstract;
using CorpusExplorer.Sdk.EchtzeitEngine.Model;
using CorpusExplorer.Sdk.Model;
using CorpusExplorer.Sdk.Utils.Filter.Queries;

namespace CorpusExplorer.Sdk.EchtzeitEngine.Calculator.Step
{
  public class CalculatorStepKwicAllInOneSentence : AbstractCalculatorStepKwic
  {
    public override string Method => "KwicAllInOneSentence";

    public override void Calculate(Selection selection, ref UniversalStorage output)
    {
      output.Set(
        selection,
        Method,
        string.Join(", ", Queries),
        RequestDataTableViaTextLive(
          selection,
          new FilterQuerySingleLayerAllInOneSentence
          {
            LayerDisplayname = "Wort",
            LayerQueries = Queries
          }));
    }
  }
}