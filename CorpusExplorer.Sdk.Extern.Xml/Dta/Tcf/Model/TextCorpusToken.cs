using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.Dta.Tcf.Model
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://www.dspin.de/data/textcorpus")]
  public class TextCorpusToken
  {
    /// <remarks />
    [XmlAttribute]
    public string ID { get; set; }

    /// <remarks />
    [XmlText]
    public string Value { get; set; }
  }
}