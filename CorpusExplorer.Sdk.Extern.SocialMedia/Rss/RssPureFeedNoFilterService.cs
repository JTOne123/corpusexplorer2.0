﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using CodeHollow.FeedReader;
using CorpusExplorer.Sdk.Extern.SocialMedia.Abstract;
using CorpusExplorer.Sdk.Helper;

namespace CorpusExplorer.Sdk.Extern.SocialMedia.Rss
{
  public class RssPureFeedNoFilterService : AbstractService
  {
    protected override void Query(object connection, IEnumerable<string> queries, string outputPath)
    {
      if (!(connection is Feed feed))
        return;

      var dir = Path.Combine(outputPath, Authentication.Settings["Name"]);
      if (!Directory.Exists(dir))
        Directory.CreateDirectory(dir);

      var serializer = new NetDataContractSerializer();
      foreach (var item in feed.Items)
      {
        using (var file = new FileStream(Path.Combine(dir, $"feed_{item.Id}-{DateTime.Now:yyyy-MM-ddTHH-mm-ss}.xml").EnsureFileName(), FileMode.Create, FileAccess.Write))
          serializer.Serialize(file, item);
      }
    }
  }
}