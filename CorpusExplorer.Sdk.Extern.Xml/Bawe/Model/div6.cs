﻿namespace CorpusExplorer.Sdk.Extern.Xml.Bawe.Model
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class div6
  {

    private head headField;

    private object[] itemsField;

    private string tEIformField;

    private string orgField;

    private string partField;

    private string sampleField;

    /// <remarks/>
    public head head
    {
      get { return this.headField; }
      set { this.headField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("figure", typeof(figure))]
    [System.Xml.Serialization.XmlElementAttribute("list", typeof(list))]
    [System.Xml.Serialization.XmlElementAttribute("p", typeof(p))]
    public object[] Items
    {
      get { return this.itemsField; }
      set { this.itemsField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
    public string TEIform
    {
      get { return this.tEIformField; }
      set { this.tEIformField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
    public string org
    {
      get { return this.orgField; }
      set { this.orgField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
    public string part
    {
      get { return this.partField; }
      set { this.partField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
    public string sample
    {
      get { return this.sampleField; }
      set { this.sampleField = value; }
    }
  }
}