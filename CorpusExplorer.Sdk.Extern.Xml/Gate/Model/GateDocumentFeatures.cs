﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.Gate.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.6.1055.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class GateDocumentFeatures
  {
    private Feature[] featureField;

    /// <remarks />
    [XmlElement("Feature")]
    public Feature[] Feature
    {
      get => featureField;
      set => featureField = value;
    }
  }
}