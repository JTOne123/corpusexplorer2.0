﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.6.1055.0.
// 
namespace CorpusExplorer.Sdk.Extern.Xml.JeanPaulLetter.Model
{

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.tei-c.org/ns/1.0")]
  [XmlRoot(Namespace = "http://www.tei-c.org/ns/1.0", IsNullable = false)]
  public partial class TEI
  {

    private teiHeader teiHeaderField;

    private body textField;

    private string idField;

    /// <remarks/>
    public teiHeader teiHeader
    {
      get { return this.teiHeaderField; }
      set { this.teiHeaderField = value; }
    }

    /// <remarks/>
    public body text
    {
      get { return this.textField; }
      set { this.textField = value; }
    }

    /// <remarks/>
    [XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string id
    {
      get { return this.idField; }
      set { this.idField = value; }
    }
  }
}