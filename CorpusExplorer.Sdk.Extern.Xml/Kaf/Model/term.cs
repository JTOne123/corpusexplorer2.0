using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.Kaf.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.6.1055.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class term
  {
    private string caseField;

    private string headField;

    private object[] itemsField;

    private string lemmaField;

    private string morphofeatField;

    private string posField;

    private string tidField;

    private string typeField;

    /// <remarks />
    [XmlAttribute]
    public string @case
    {
      get => caseField;
      set => caseField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string head
    {
      get => headField;
      set => headField = value;
    }

    /// <remarks />
    [XmlElement("component", typeof(component))]
    [XmlElement("externalReferences", typeof(externalReferences))]
    [XmlElement("sentiment", typeof(sentiment))]
    [XmlElement("span", typeof(span))]
    public object[] Items
    {
      get => itemsField;
      set => itemsField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string lemma
    {
      get => lemmaField;
      set => lemmaField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string morphofeat
    {
      get => morphofeatField;
      set => morphofeatField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string pos
    {
      get => posField;
      set => posField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string tid
    {
      get => tidField;
      set => tidField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string type
    {
      get => typeField;
      set => typeField = value;
    }
  }
}