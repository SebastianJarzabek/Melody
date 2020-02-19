using System;

namespace Melody.Service.Entity
{
  public class WarehouseIssue
  {
    public int WarehouseIssueId { get; set; }

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
