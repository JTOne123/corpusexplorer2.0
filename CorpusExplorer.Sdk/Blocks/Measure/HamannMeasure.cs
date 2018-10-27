﻿#region

using System;
using CorpusExplorer.Sdk.Blocks.Measure.Abstract;

#endregion

namespace CorpusExplorer.Sdk.Blocks.Measure
{
  /// <summary>
  ///   The hamann measure.
  /// </summary>
  [Serializable]
  public sealed class HamannMeasure : AbstractMeasure
  {
    public override double Calculate(double k, double k0, double ki, double kj, double kij)
    {
      return (k0 + kij - (ki + kj)) / GetP(k0, ki, kj, kij);
    }
  }
}