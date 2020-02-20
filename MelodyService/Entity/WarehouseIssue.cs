﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class WarehouseIssue
  {
    public int IdWarehouseIssue { get; set; }

    public DateTime DateOfReceipt { get; set; }

    public string ReceivingEmployee { get; set; }

    public string HostEmployee { get; set; }

    public Order Order { get; set; }

    public Destiny Destiny { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }

    public Note Note { get; set; }
  }
}
