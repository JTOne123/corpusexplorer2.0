﻿namespace CorpusExplorer.Sdk.Extern.Xml.Perseus.Model
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.tei-c.org/ns/1.0")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.tei-c.org/ns/1.0", IsNullable = false)]
  public partial class fileDesc
  {

    private titleStmt titleStmtField;

    private p publicationStmtField;

    private p sourceDescField;

    /// <remarks/>
    public titleStmt titleStmt
    {
      get { return this.titleStmtField; }
      set { this.titleStmtField = value; }
    }

    /// <remarks/>
    public p publicationStmt
    {
      get { return this.publicationStmtField; }
      set { this.publicationStmtField = value; }
    }

    /// <remarks/>
    public p sourceDesc
    {
      get { return this.sourceDescField; }
      set { this.sourceDescField = value; }
    }
  }
}