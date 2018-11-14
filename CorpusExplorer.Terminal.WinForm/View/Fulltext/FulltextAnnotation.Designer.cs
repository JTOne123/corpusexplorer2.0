using CorpusExplorer.Terminal.WinForm.Properties;
using CorpusExplorer.Terminal.WinForm.Controls.Wpf.Tagger;

namespace CorpusExplorer.Terminal.WinForm.View.Fulltext
{
  partial class FulltextAnnotation
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.drop_selectedtext = new Telerik.WinControls.UI.RadCommandBar();
      this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
      this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
      this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
      this.drop_selecteddocument = new Telerik.WinControls.UI.CommandBarDropDownList();
      this.btn_showMeta = new Telerik.WinControls.UI.CommandBarButton();
      this.btn_export = new Telerik.WinControls.UI.CommandBarButton();
      this.btn_clipboard = new Telerik.WinControls.UI.CommandBarButton();
      this.tree = new Telerik.WinControls.UI.RadTreeView();
      this.radCommandBar2 = new Telerik.WinControls.UI.RadCommandBar();
      this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
      this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
      this.btn_layer_new = new Telerik.WinControls.UI.CommandBarButton();
      this.radLabel55 = new Telerik.WinControls.UI.RadLabel();
      this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
      this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.tagger1 = new CorpusExplorer.Terminal.WinForm.Controls.Wpf.Tagger.WpfTagger();
      this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
      this.txt_layer_query = new Telerik.WinControls.UI.RadTextBox();
      this.menu_layer = new Telerik.WinControls.UI.RadContextMenu(this.components);
      this.btn_layer_addValue = new Telerik.WinControls.UI.RadMenuItem();
      this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
      this.btn_layer_rename = new Telerik.WinControls.UI.RadMenuItem();
      this.btn_layer_remove = new Telerik.WinControls.UI.RadMenuItem();
      this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
      this.btn_layer_export = new Telerik.WinControls.UI.RadMenuItem();
      this.btn_layer_import = new Telerik.WinControls.UI.RadMenuItem();
      this.menu_layervalue = new Telerik.WinControls.UI.RadContextMenu(this.components);
      this.btn_layervalue_rename = new Telerik.WinControls.UI.RadMenuItem();
      this.btn_layervalue_remove = new Telerik.WinControls.UI.RadMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.drop_selectedtext)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radCommandBar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radLabel55)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
      this.radSplitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
      this.splitPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
      this.splitPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_layer_query)).BeginInit();
      this.SuspendLayout();
      // 
      // drop_selectedtext
      // 
      this.drop_selectedtext.Dock = System.Windows.Forms.DockStyle.Top;
      this.drop_selectedtext.Location = new System.Drawing.Point(0, 0);
      this.drop_selectedtext.Name = "drop_selectedtext";
      this.drop_selectedtext.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
      this.drop_selectedtext.Size = new System.Drawing.Size(780, 44);
      this.drop_selectedtext.TabIndex = 1;
      // 
      // commandBarRowElement1
      // 
      this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
      this.commandBarRowElement1.Name = "commandBarRowElement1";
      this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
      this.commandBarRowElement1.Text = "";
      // 
      // commandBarStripElement1
      // 
      this.commandBarStripElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
      this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
      this.commandBarStripElement1.EnableDragging = false;
      this.commandBarStripElement1.EnableFloating = true;
      this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel1,
            this.drop_selecteddocument,
            this.btn_showMeta,
            this.btn_export,
            this.btn_clipboard});
      this.commandBarStripElement1.Name = "commandBarStripElement1";
      // 
      // commandBarLabel1
      // 
      this.commandBarLabel1.DisplayName = "commandBarLabel1";
      this.commandBarLabel1.Name = "commandBarLabel1";
      this.commandBarLabel1.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.TextDP;
      // 
      // drop_selecteddocument
      // 
      this.drop_selecteddocument.DisplayName = "commandBarDropDownList1";
      this.drop_selecteddocument.DropDownAnimationEnabled = true;
      this.drop_selecteddocument.MaxDropDownItems = 0;
      this.drop_selecteddocument.MinSize = new System.Drawing.Size(300, 22);
      this.drop_selecteddocument.Name = "drop_selecteddocument";
      this.drop_selecteddocument.Text = "";
      this.drop_selecteddocument.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.drop_selecteddocument_SelectedIndexChanged);
      // 
      // btn_showMeta
      // 
      this.btn_showMeta.DisplayName = "commandBarButton1";
      this.btn_showMeta.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.tag_green;
      this.btn_showMeta.Name = "btn_showMeta";
      this.btn_showMeta.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.MetadatenAnzeigen;
      this.btn_showMeta.ToolTipText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.MetadatenAnzeigen;
      this.btn_showMeta.Click += new System.EventHandler(this.btn_showMeta_Click);
      // 
      // btn_export
      // 
      this.btn_export.DisplayName = "commandBarButton1";
      this.btn_export.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.export_text;
      this.btn_export.Name = "btn_export";
      this.btn_export.Text = "Aktuelles Dokument exportieren";
      this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
      // 
      // btn_clipboard
      // 
      this.btn_clipboard.DisplayName = "commandBarButton1";
      this.btn_clipboard.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.clipboard_copy;
      this.btn_clipboard.Name = "btn_clipboard";
      this.btn_clipboard.Text = "In die Zwischenablage kopieren";
      this.btn_clipboard.Click += new System.EventHandler(this.btn_clipboard_Click);
      // 
      // tree
      // 
      this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tree.ItemHeight = 40;
      this.tree.Location = new System.Drawing.Point(25, 32);
      this.tree.Name = "tree";
      this.tree.Size = new System.Drawing.Size(275, 279);
      this.tree.SpacingBetweenNodes = -1;
      this.tree.TabIndex = 2;
      this.tree.TreeIndent = 40;
      this.tree.NodeCheckedChanged += new Telerik.WinControls.UI.TreeNodeCheckedEventHandler(this.tree_NodeCheckedChanged);
      // 
      // radCommandBar2
      // 
      this.radCommandBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.radCommandBar2.Location = new System.Drawing.Point(25, 311);
      this.radCommandBar2.Name = "radCommandBar2";
      this.radCommandBar2.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement2});
      this.radCommandBar2.Size = new System.Drawing.Size(275, 45);
      this.radCommandBar2.TabIndex = 1;
      // 
      // commandBarRowElement2
      // 
      this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
      this.commandBarRowElement2.Name = "commandBarRowElement2";
      this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement2});
      this.commandBarRowElement2.Text = "";
      // 
      // commandBarStripElement2
      // 
      this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
      this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.btn_layer_new});
      this.commandBarStripElement2.Name = "commandBarStripElement2";
      // 
      // btn_layer_new
      // 
      this.btn_layer_new.AccessibleDescription = "commandBarButton1";
      this.btn_layer_new.AccessibleName = "commandBarButton1";
      this.btn_layer_new.DisplayName = "commandBarButton1";
      this.btn_layer_new.DrawText = true;
      this.btn_layer_new.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.add_button;
      this.btn_layer_new.MinSize = new System.Drawing.Size(38, 38);
      this.btn_layer_new.Name = "btn_layer_new";
      this.btn_layer_new.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.NeuerLayer;
      this.btn_layer_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btn_layer_new.Click += new System.EventHandler(this.btn_layer_new_Click);
      // 
      // radLabel55
      // 
      this.radLabel55.Dock = System.Windows.Forms.DockStyle.Left;
      this.radLabel55.ForeColor = System.Drawing.Color.DarkSeaGreen;
      this.radLabel55.Location = new System.Drawing.Point(2, 0);
      this.radLabel55.Name = "radLabel55";
      this.radLabel55.Size = new System.Drawing.Size(23, 121);
      this.radLabel55.TabIndex = 0;
      this.radLabel55.Text = "Verfügbare Layer";
      ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel55.GetChildAt(0))).Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.VerfügbareLayer;
      ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel55.GetChildAt(0))).AngleTransform = 270F;
      // 
      // radSplitContainer1
      // 
      this.radSplitContainer1.Controls.Add(this.splitPanel1);
      this.radSplitContainer1.Controls.Add(this.splitPanel2);
      this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radSplitContainer1.Location = new System.Drawing.Point(0, 44);
      this.radSplitContainer1.Name = "radSplitContainer1";
      // 
      // 
      // 
      this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
      this.radSplitContainer1.Size = new System.Drawing.Size(780, 356);
      this.radSplitContainer1.TabIndex = 4;
      this.radSplitContainer1.TabStop = false;
      // 
      // splitPanel1
      // 
      this.splitPanel1.Controls.Add(this.elementHost1);
      this.splitPanel1.Location = new System.Drawing.Point(0, 0);
      this.splitPanel1.Name = "splitPanel1";
      // 
      // 
      // 
      this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(0, 0);
      this.splitPanel1.Size = new System.Drawing.Size(476, 356);
      this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1139359F, 0F);
      this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(57, 0);
      this.splitPanel1.TabIndex = 0;
      this.splitPanel1.TabStop = false;
      this.splitPanel1.Text = "splitPanel1";
      // 
      // elementHost1
      // 
      this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.elementHost1.Location = new System.Drawing.Point(0, 0);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(476, 356);
      this.elementHost1.TabIndex = 0;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = this.tagger1;
      // 
      // splitPanel2
      // 
      this.splitPanel2.Controls.Add(this.tree);
      this.splitPanel2.Controls.Add(this.txt_layer_query);
      this.splitPanel2.Controls.Add(this.radCommandBar2);
      this.splitPanel2.Controls.Add(this.radLabel55);
      this.splitPanel2.Location = new System.Drawing.Point(480, 0);
      this.splitPanel2.Name = "splitPanel2";
      this.splitPanel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
      // 
      // 
      // 
      this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(0, 0);
      this.splitPanel2.Size = new System.Drawing.Size(300, 356);
      this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.113936F, 0F);
      this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(-57, 0);
      this.splitPanel2.TabIndex = 1;
      this.splitPanel2.TabStop = false;
      this.splitPanel2.Text = "splitPanel2";
      // 
      // txt_layer_query
      // 
      this.txt_layer_query.Dock = System.Windows.Forms.DockStyle.Top;
      this.txt_layer_query.Location = new System.Drawing.Point(25, 0);
      this.txt_layer_query.Name = "txt_layer_query";
      this.txt_layer_query.NullText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.FilterHierEingeben;
      this.txt_layer_query.Size = new System.Drawing.Size(275, 32);
      this.txt_layer_query.TabIndex = 3;
      this.txt_layer_query.TextChanged += new System.EventHandler(this.txt_layer_query_TextChanged);
      // 
      // menu_layer
      // 
      this.menu_layer.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btn_layer_addValue,
            this.radMenuSeparatorItem1,
            this.btn_layer_rename,
            this.btn_layer_remove,
            this.radMenuSeparatorItem2,
            this.btn_layer_export,
            this.btn_layer_import});
      // 
      // btn_layer_addValue
      // 
      this.btn_layer_addValue.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.add_button;
      this.btn_layer_addValue.Name = "btn_layer_addValue";
      this.btn_layer_addValue.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.NeuenLayerwertHinzufügen;
      this.btn_layer_addValue.Click += new System.EventHandler(this.btn_layer_addValue_Click);
      // 
      // radMenuSeparatorItem1
      // 
      this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
      this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
      this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btn_layer_rename
      // 
      this.btn_layer_rename.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.rename1;
      this.btn_layer_rename.Name = "btn_layer_rename";
      this.btn_layer_rename.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.LayerUmbenennen;
      this.btn_layer_rename.Click += new System.EventHandler(this.btn_layer_rename_Click);
      // 
      // btn_layer_remove
      // 
      this.btn_layer_remove.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.remove_button;
      this.btn_layer_remove.Name = "btn_layer_remove";
      this.btn_layer_remove.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.LayerLöschen;
      this.btn_layer_remove.Click += new System.EventHandler(this.btn_layer_remove_Click);
      // 
      // radMenuSeparatorItem2
      // 
      this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
      this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
      this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btn_layer_export
      // 
      this.btn_layer_export.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.folder_action_open;
      this.btn_layer_export.Name = "btn_layer_export";
      this.btn_layer_export.Text = "Layer exportieren";
      this.btn_layer_export.Click += new System.EventHandler(this.btn_layer_export_Click);
      // 
      // btn_layer_import
      // 
      this.btn_layer_import.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.folder_action_close;
      this.btn_layer_import.Name = "btn_layer_import";
      this.btn_layer_import.Text = "Layer importieren";
      this.btn_layer_import.Click += new System.EventHandler(this.btn_layer_import_Click);
      // 
      // menu_layervalue
      // 
      this.menu_layervalue.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btn_layervalue_rename,
            this.btn_layervalue_remove});
      // 
      // btn_layervalue_rename
      // 
      this.btn_layervalue_rename.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.rename1;
      this.btn_layervalue_rename.Name = "btn_layervalue_rename";
      this.btn_layervalue_rename.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.LayerwertUmbenennen;
      this.btn_layervalue_rename.Click += new System.EventHandler(this.btn_layervalue_rename_Click);
      // 
      // btn_layervalue_remove
      // 
      this.btn_layervalue_remove.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.remove_button;
      this.btn_layervalue_remove.Name = "btn_layervalue_remove";
      this.btn_layervalue_remove.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.LayerwertLöschen;
      this.btn_layervalue_remove.Click += new System.EventHandler(this.btn_layervalue_remove_Click);
      // 
      // FulltextAnnotation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.Controls.Add(this.radSplitContainer1);
      this.Controls.Add(this.drop_selectedtext);
      this.Name = "FulltextAnnotation";
      ((System.ComponentModel.ISupportInitialize)(this.drop_selectedtext)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radCommandBar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radLabel55)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
      this.radSplitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
      this.splitPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
      this.splitPanel2.ResumeLayout(false);
      this.splitPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_layer_query)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadCommandBar drop_selectedtext;
    private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
    private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
    private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
    private Telerik.WinControls.UI.CommandBarDropDownList drop_selecteddocument;
    private Telerik.WinControls.UI.RadTreeView tree;
    private Telerik.WinControls.UI.RadCommandBar radCommandBar2;
    private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
    private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
    private Telerik.WinControls.UI.CommandBarButton btn_layer_new;
    private Telerik.WinControls.UI.RadLabel radLabel55;
    private Telerik.WinControls.UI.CommandBarButton btn_showMeta;
    private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
    private Telerik.WinControls.UI.SplitPanel splitPanel1;
    private Telerik.WinControls.UI.SplitPanel splitPanel2;
    private Telerik.WinControls.UI.RadContextMenu menu_layer;
    private Telerik.WinControls.UI.RadMenuItem btn_layer_addValue;
    private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
    private Telerik.WinControls.UI.RadMenuItem btn_layer_rename;
    private Telerik.WinControls.UI.RadMenuItem btn_layer_remove;
    private Telerik.WinControls.UI.RadContextMenu menu_layervalue;
    private Telerik.WinControls.UI.RadMenuItem btn_layervalue_rename;
    private Telerik.WinControls.UI.RadMenuItem btn_layervalue_remove;
    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private Controls.Wpf.Tagger.WpfTagger tagger1;
    private Telerik.WinControls.UI.RadTextBox txt_layer_query;
    private Telerik.WinControls.UI.CommandBarButton btn_export;
    private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
    private Telerik.WinControls.UI.RadMenuItem btn_layer_export;
    private Telerik.WinControls.UI.RadMenuItem btn_layer_import;
    private Telerik.WinControls.UI.CommandBarButton btn_clipboard;
  }
}
