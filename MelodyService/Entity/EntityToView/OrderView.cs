using System;

namespace Melody.Service.Entity.EntityToView
{
  public class OrderView
  {
    public int IdOrder { get; set; }

    public int OrderNumber { get; set; }

    public DateTime DateOfOrder { get; set; }

    public string OrderingEmployee { get; set; }

    public string SupplierName { get; set; }

    public string DestinyName { get; set; }

    public string Contract { get; set; }

    public string MaterialName { get; set; }

    public string MaterialType { get; set; }

    public int Quantity { get; set; }

    public string UnitName { get; set; }

    public string NoteFullText { get; set; }

    public string ReceivingEmployee { get; set; }

    public DateTime PlannedDateOfReceipt { get; set; }
  }
}
