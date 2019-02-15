﻿using System.Collections.Generic;
using CorpusExplorer.Sdk.Extern.SocialMedia.Gui.Controls.Abstract;

namespace CorpusExplorer.Sdk.Extern.SocialMedia.Gui.Controls
{
  public partial class EndpointRequestSimple : AbstractEndpointRequest
  {
    public EndpointRequestSimple()
    {
      InitializeComponent();
    }

    protected override void ExecuteBackgroundWorker()
    {
      OnExecute(new Dictionary<string, object> {{"queries", radTextBox1.Lines}});
    }
  }
}