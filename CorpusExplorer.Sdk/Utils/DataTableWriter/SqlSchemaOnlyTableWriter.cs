﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using CorpusExplorer.Sdk.Utils.DataTableWriter.Abstract;

namespace CorpusExplorer.Sdk.Utils.DataTableWriter
{
  public class SqlSchemaOnlyTableWriter : AbstractTableWriter
  {
    public override string TableWriterTag => "F:SQLSCHEMA";
    public override string MimeType => "application/sql";

    public override void WriteTable(string tid, DataTable table)
    {
      lock (WriteLock)
      {
        tid = MakeTidSqlSafe(tid);

        WriteHead(table);

        var columns = new List<Tuple<string, string, Type>>();
        foreach (DataColumn column in table.Columns)
          columns.Add(new Tuple<string, string, Type>(column.ColumnName, column.ColumnName.Replace(" ", "_"),
                                                      column.DataType));

        var stb = new StringBuilder($"CREATE TABLE CorpusExplorer_{tid} (");
        foreach (var column in columns)
          stb.Append($"{column.Item2} {GetSqlType(column.Item3)},");
        stb.Remove(stb.Length - 1, 1);
        stb.Append(");");
        stb.AppendLine();
        WriteOutput(stb.ToString());
      }
    }

    protected override void WriteHead(DataTable table)
    {
      if (_headInitialized)
        return;

      _headInitialized = true;

      WriteOutput("-- before you add this table to the database:\r\n");
      WriteOutput("-- 1. change table name(s)\r\n");
      WriteOutput("-- 2. check & change datatypes\r\n");
      WriteOutput("-- 3. set (primary) key(s)\r\n");
    }

    protected override void WriteBody(string tid, DataTable table) { }

    protected override void WriteFooter() { }

    private string MakeTidSqlSafe(string tid)
      => tid.Replace("*", "_").Replace(" ", "_");

    public override AbstractTableWriter Clone(Stream stream)
      => new SqlSchemaOnlyTableWriter { OutputStream = stream };

    private string GetSqlType(Type type)
    {
      if (type == typeof(DateTime))
        return "DATE";
      if (type == typeof(double))
        return "FLOAT";
      if (type == typeof(int))
        return "INT";
      if (type == typeof(string))
        return "TEXT";

      return "UNKNOWN";
    }
  }
}