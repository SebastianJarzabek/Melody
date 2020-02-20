﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class WarehouseAdmission
  {
    public int IdWarehouseAdmission { get; set; }

    public DateTime DateOfAdmission { get; set; }

    public string HostEmployee { get; set; }

    public Supplier Supplier { get; set; }

    public Order Order { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }

    public Destiny Destiny { get; set; }

    public Note Note { get; set; }
  }
}
