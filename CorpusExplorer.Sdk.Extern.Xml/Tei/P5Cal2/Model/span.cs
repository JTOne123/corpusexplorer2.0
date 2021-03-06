﻿namespace CorpusExplorer.Sdk.Extern.Xml.Tei.P5Cal2.Model
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tei-c.org/ns/1.0")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.tei-c.org/ns/1.0", IsNullable = false)]
  public partial class span
  {

    private object[] itemsField;

    private string[] textField;

    private string styleField;

    private string typeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("figure", typeof(figure))]
    [System.Xml.Serialization.XmlElementAttribute("hi", typeof(hi))]
    [System.Xml.Serialization.XmlElementAttribute("note", typeof(note))]
    [System.Xml.Serialization.XmlElementAttribute("ref", typeof(@ref))]
    [System.Xml.Serialization.XmlElementAttribute("span", typeof(span))]
    public object[] Items
    {
      get { return this.itemsField; }
      set { this.itemsField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
      get { return this.textField; }
      set { this.textField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string style
    {
      get { return this.styleField; }
      set { this.styleField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
    public string type
    {
      get { return this.typeField; }
      set { this.typeField = value; }
    }
  }
}