#region

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

#endregion

namespace CorpusExplorer.Sdk.Extern.Xml.Tei.Bare.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.0.30319.33440")]
  [Serializable]
  [XmlType(Namespace = "http://www.tei-c.org/ns/1.0", IncludeInSchema = false)]
  public enum ItemsChoiceType3
  {
    /// <remarks />
    div,

    /// <remarks />
    [XmlEnum("model.common")] modelcommon,

    /// <remarks />
    [XmlEnum("model.divLike")] modeldivLike
  }
}