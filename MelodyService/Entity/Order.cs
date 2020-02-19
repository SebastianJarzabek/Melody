using System;

namespace Melody.Service.Entity
{
  public class Order
  {
    public int OrderId { get; set; }

    public DateTime DateOfOrder { get; set; }

    public string OrderingEmployee { get; set; }

    public Supplier Supplier { get; set; }

    public Destiny Destiny { get; set; }

    public Material Material { get; set; }

    public int Quantity { get; set; }

    public Unit Unit { get; set; }

    public Note Note { get; set; }

    public string ReceivingEmployee { get; set; }

    public DateTime PlannedDateOfReceipt { get; set; }
  }
}
