﻿using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class InventoryLevel
  {
    public int Id { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }
  }
}
