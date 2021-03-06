﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Linq;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;

namespace CorpusExplorer.Sdk.Db.CorpusDb
{
  public class CorpusExplorerModel : OpenAccessContext, ICorpusExplorerModelUnitOfWork
  {
    private static readonly string connectionStringName = @"PrototypeConnection";
    private static readonly BackendConfiguration backend = GetBackendConfiguration();
    private static readonly MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntitiesModel.rlinq");

    public CorpusExplorerModel()
      : base(connectionStringName, backend, metadataSource) {}

    public CorpusExplorerModel(string connection)
      : base(connection, backend, metadataSource) {}

    public CorpusExplorerModel(BackendConfiguration backendConfiguration)
      : base(connectionStringName, backendConfiguration, metadataSource) {}

    public CorpusExplorerModel(string connection, MetadataSource metadataSource)
      : base(connection, backend, metadataSource) {}

    public CorpusExplorerModel(string connection, BackendConfiguration backendConfiguration,
                               MetadataSource metadataSource)
      : base(connection, backendConfiguration, metadataSource) {}

    public IQueryable<Corpus> Corpus
    {
      get { return GetAll<Corpus>(); }
    }

    public IQueryable<CorpusMetadata> CorpusMetadatas
    {
      get { return GetAll<CorpusMetadata>(); }
    }

    public IQueryable<DocumentLayerIndex> DocumentLayerIndices
    {
      get { return GetAll<DocumentLayerIndex>(); }
    }

    public IQueryable<DocumentMetadata> DocumentMetadatas
    {
      get { return GetAll<DocumentMetadata>(); }
    }

    public IQueryable<Document> Documents
    {
      get { return GetAll<Document>(); }
    }

    public IQueryable<LayerIndex> LayerIndices
    {
      get { return GetAll<LayerIndex>(); }
    }

    public IQueryable<Layer> Layers
    {
      get { return GetAll<Layer>(); }
    }

    public static BackendConfiguration GetBackendConfiguration()
    {
      var backend = new BackendConfiguration
                    {
                      Backend = "SQLite",
                      ProviderName = "System.Data.SQLite"
                    };
      backend.Logging.MetricStoreSnapshotInterval = 0;

      CustomizeBackendConfiguration(ref backend);

      return backend;
    }

    /// <summary>
    ///   Allows you to customize the BackendConfiguration of CorpusExplorerModel.
    /// </summary>
    /// <param name="config">The BackendConfiguration of CorpusExplorerModel.</param>
    static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
  }

  public interface ICorpusExplorerModelUnitOfWork : IUnitOfWork
  {
    IQueryable<Corpus> Corpus { get; }

    IQueryable<CorpusMetadata> CorpusMetadatas { get; }

    IQueryable<DocumentLayerIndex> DocumentLayerIndices { get; }

    IQueryable<DocumentMetadata> DocumentMetadatas { get; }

    IQueryable<Document> Documents { get; }

    IQueryable<LayerIndex> LayerIndices { get; }

    IQueryable<Layer> Layers { get; }
  }
}

#pragma warning restore 1591