﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.5485
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CorpusExplorer.Sdk.Extern.Xml.Talkbank.Model
{
  using System.Xml.Serialization;

  // 
  // This source code was auto-generated by xsd, Version=2.0.50727.3038.
  // 


  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [XmlType(AnonymousType=true, Namespace="http://www.talkbank.org/ns/talkbank")]
  [XmlRoot(Namespace="http://www.talkbank.org/ns/talkbank", IsNullable=false)]
  public partial class CHAT {
    
    private Metadata metadataField;
    
    private participantType[] participantsField;
    
    private object[] itemsField;
    
    private string idField;
    
    private string versionField;
    
    private System.DateTime dateField;
    
    private string corpusField;
    
    private string mediaField;
    
    private mediaTypeType[] mediatypesField;
    
    private string[] langField;
    
    private optionType[] optionsField;
    
    private string colorwordsField;
    
    private string pIDField;
    
    private string fontField;
    
    /// <remarks/>
    public Metadata Metadata {
      get {
        return this.metadataField;
      }
      set {
        this.metadataField = value;
      }
    }
    
    /// <remarks/>
    [XmlArrayItem("participant", IsNullable=false)]
    public participantType[] Participants {
      get {
        return this.participantsField;
      }
      set {
        this.participantsField = value;
      }
    }
    
    /// <remarks/>
    [XmlElement("begin-gem", typeof(CHATBegingem))]
    [XmlElement("comment", typeof(commentType))]
    [XmlElement("end-gem", typeof(CHATEndgem))]
    [XmlElement("lazy-gem", typeof(CHATLazygem))]
    [XmlElement("tcu", typeof(tcuType1))]
    [XmlElement("u", typeof(speakerUtteranceType))]
    public object[] Items {
      get {
        return this.itemsField;
      }
      set {
        this.itemsField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public string Id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public string Version {
      get {
        return this.versionField;
      }
      set {
        this.versionField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute(DataType="date")]
    public System.DateTime Date {
      get {
        return this.dateField;
      }
      set {
        this.dateField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public string Corpus {
      get {
        return this.corpusField;
      }
      set {
        this.corpusField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public string Media {
      get {
        return this.mediaField;
      }
      set {
        this.mediaField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public mediaTypeType[] Mediatypes {
      get {
        return this.mediatypesField;
      }
      set {
        this.mediatypesField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute(DataType="language")]
    public string[] Lang {
      get {
        return this.langField;
      }
      set {
        this.langField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public optionType[] Options {
      get {
        return this.optionsField;
      }
      set {
        this.optionsField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public string Colorwords {
      get {
        return this.colorwordsField;
      }
      set {
        this.colorwordsField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public string PID {
      get {
        return this.pIDField;
      }
      set {
        this.pIDField = value;
      }
    }
    
    /// <remarks/>
    [XmlAttribute()]
    public string Font {
      get {
        return this.fontField;
      }
      set {
        this.fontField = value;
      }
    }
  }
}