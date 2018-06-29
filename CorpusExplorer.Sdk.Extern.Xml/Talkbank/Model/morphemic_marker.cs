#region

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace CorpusExplorer.Sdk.Extern.Xml.Talkbank.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.talkbank.org/ns/talkbank")]
  [XmlRoot("mk", Namespace = "http://www.talkbank.org/ns/talkbank", IsNullable = false)]
  public class morphemic_marker
  {
    private morphemic_markerType typeField;
    private string valueField;

    /// <remarks />
    [XmlAttribute]
    public morphemic_markerType type
    {
      get => typeField;
      set => typeField = value;
    }

    /// <remarks />
    [XmlText]
    public string Value
    {
      get => valueField;
      set => valueField = value;
    }
  }
}