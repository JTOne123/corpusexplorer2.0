﻿#region

using Newtonsoft.Json;

#endregion

namespace CorpusExplorer.Sdk.Extern.Json.YourTwapperKeeper.Model
{
  // Generated by Xamasoft JSON Class Generator
  // http://www.xamasoft.com/json-class-generator

  public class TwapperCorpus
  {
    [JsonProperty("archive_info")] public ArchiveInfo ArchiveInfo { get; set; }

    [JsonProperty("tweets")] public Tweet[] Tweets { get; set; }
  }
}