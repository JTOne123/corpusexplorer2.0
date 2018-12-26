namespace CorpusExplorer.Terminal.WinForm.Forms.SelectLayer
{
  partial class Select3Layer
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select3Layer));
      this.layerSettings1 = new CorpusExplorer.Terminal.WinForm.Controls.WinForm.LayerSettings();
      this.layerSettings2 = new CorpusExplorer.Terminal.WinForm.Controls.WinForm.LayerSettings();
      this.layerSettings3 = new CorpusExplorer.Terminal.WinForm.Controls.WinForm.LayerSettings();
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radPanel1
      // 
      resources.ApplyResources(this.radPanel1, "radPanel1");
      // 
      // layerSettings1
      // 
      this.layerSettings1.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.layerSettings1, "layerSettings1");
      this.layerSettings1.Header = "Layer 1";
      this.layerSettings1.IsLayerOptional = false;
      this.layerSettings1.Name = "layerSettings1";
      // 
      // layerSettings2
      // 
      this.layerSettings2.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.layerSettings2, "layerSettings2");
      this.layerSettings2.Header = "Layer 2";
      this.layerSettings2.IsLayerOptional = true;
      this.layerSettings2.Name = "layerSettings2";
      // 
      // layerSettings3
      // 
      this.layerSettings3.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.layerSettings3, "layerSettings3");
      this.layerSettings3.Header = "Layer 3";
      this.layerSettings3.IsLayerOptional = true;
      this.layerSettings3.Name = "layerSettings3";
      // 
      // Select3Layer
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.layerSettings3);
      this.Controls.Add(this.layerSettings2);
      this.Controls.Add(this.layerSettings1);
      this.DisplayAbort = true;
      this.Name = "Select3Layer";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.ButtonOkClick += new System.EventHandler(this.Form_ButtonOkClick);
      this.Controls.SetChildIndex(this.header1, 0);
      this.Controls.SetChildIndex(this.radPanel1, 0);
      this.Controls.SetChildIndex(this.layerSettings1, 0);
      this.Controls.SetChildIndex(this.layerSettings2, 0);
      this.Controls.SetChildIndex(this.layerSettings3, 0);
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.WinForm.LayerSettings layerSettings1;
    private Controls.WinForm.LayerSettings layerSettings2;
    private Controls.WinForm.LayerSettings layerSettings3;
  }
}