using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.SlashA.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.6.81.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.dspin.de/data/metadata")]
  [XmlRoot(Namespace = "http://www.dspin.de/data/metadata", IsNullable = false)]
  public class number
  {
    private string letterField;

    private string volumeField;

    /// <remarks />
    [XmlAttribute(DataType = "integer")]
    public string letter
    {
      get => letterField;
      set => letterField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "NCName")]
    public string volume
    {
      get => volumeField;
      set => volumeField = value;
    }
  }
}