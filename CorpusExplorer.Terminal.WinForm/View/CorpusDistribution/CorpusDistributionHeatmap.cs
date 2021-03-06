using CorpusExplorer.Terminal.WinForm.Helper;
using CorpusExplorer.Terminal.WinForm.Properties;

#region

using System;
using System.Linq;
using CorpusExplorer.Sdk.ViewModel;
using CorpusExplorer.Terminal.WinForm.Forms.Splash;
using CorpusExplorer.Terminal.WinForm.Helper.UiFramework;
using Telerik.WinControls.UI.Data;

#endregion

namespace CorpusExplorer.Terminal.WinForm.View.CorpusDistribution
{
  /// <summary>
  ///   The heat map visualisation.
  /// </summary>
  public partial class CorpusDistributionHeatmap : AbstractView
  {
    private CorpusWeightLimmitedViewModel _vm;
    private Controls.Wpf.HeatMap.HeatMapView heatMapView1 = new Controls.Wpf.HeatMap.HeatMapView();

    /// <summary>
    ///   Initializes a new instance of the <see cref="AbstractView" /> class.
    /// </summary>
    public CorpusDistributionHeatmap()
    {
      InitializeComponent();
      heatMapView1.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
      heatMapView1.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
      elementHost1.Child = heatMapView1;

      ShowView += ShowViewCall;
    }

    private void Analyse()
    {
      _vm.Execute();
      var demo = _vm.GetDataTable();
      heatMapView1.SetDataSource(demo);
    }

    private void btn_export_Click(object sender, EventArgs e)
    {
      DataTableExporter.Export(_vm.GetDataTable());
    }

    private void combo_group_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
    {
      if (combo_groupA.SelectedIndex == -1 ||
          combo_groupB.SelectedIndex == -1 ||
          combo_groupA.SelectedIndex == combo_groupB.SelectedIndex)
        return;

      _vm.CategroyA = combo_groupA.SelectedItem.Text;
      _vm.CategroyB = combo_groupB.SelectedItem.Text;

      Processing.Invoke(Resources.VergleicheMetadaten, Analyse);
    }

    private void ShowViewCall(object sender, EventArgs e)
    {
      _vm = GetViewModel<CorpusWeightLimmitedViewModel>();

      var groupA = Project.CurrentSelection.GetDocumentMetadataPrototypeOnlyProperties().ToList();
      var groupB = Project.CurrentSelection.GetDocumentMetadataPrototypeOnlyProperties().ToList();

      if (groupA.Contains("GUID"))
        groupA.Remove("GUID");
      if (groupB.Contains("GUID"))
        groupB.Remove("GUID");

      combo_groupA.DataSource = groupA;
      combo_groupB.DataSource = groupB;

      combo_groupA.SelectedValue = groupA.FirstOrDefault();
      combo_groupB.SelectedValue = groupB.Last();
    }
  }
}