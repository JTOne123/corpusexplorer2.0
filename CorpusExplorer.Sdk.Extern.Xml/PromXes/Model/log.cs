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

namespace CorpusExplorer.Sdk.Extern.Xml.PromXes.Model
{

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.xes-standard.org/")]
  [XmlRoot(Namespace = "http://www.xes-standard.org/", IsNullable = false)]
  public partial class log
  {

    private extension[] extensionField;

    private global[] globalField;

    private classifier[] classifierField;

    private object[] itemsField;

    private trace[] traceField;

    private string openxesversionField;

    private string xesfeaturesField;

    private decimal xesversionField;

    /// <remarks/>
    [XmlElement("extension")]
    public extension[] extension { get { return this.extensionField; } set { this.extensionField = value; } }

    /// <remarks/>
    [XmlElement("global")]
    public global[] global { get { return this.globalField; } set { this.globalField = value; } }

    /// <remarks/>
    [XmlElement("classifier")]
    public classifier[] classifier { get { return this.classifierField; } set { this.classifierField = value; } }

    /// <remarks/>
    [XmlElement("date", typeof(date))]
    [XmlElement("float", typeof(@float))]
    [XmlElement("int", typeof(@int))]
    [XmlElement("string", typeof(@string))]
    public object[] Items { get { return this.itemsField; } set { this.itemsField = value; } }

    /// <remarks/>
    [XmlElement("trace")]
    public trace[] trace { get { return this.traceField; } set { this.traceField = value; } }

    /// <remarks/>
    [XmlAttribute("openxes.version", DataType = "NMTOKEN")]
    public string openxesversion { get { return this.openxesversionField; } set { this.openxesversionField = value; } }

    /// <remarks/>
    [XmlAttribute("xes.features", DataType = "NCName")]
    public string xesfeatures { get { return this.xesfeaturesField; } set { this.xesfeaturesField = value; } }

    /// <remarks/>
    [XmlAttribute("xes.version")]
    public decimal xesversion { get { return this.xesversionField; } set { this.xesversionField = value; } }
  }
}