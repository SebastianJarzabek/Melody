using System;

namespace Melody.Service.Entity.EntityToView
{
  public class MaterialReceiptView
  {
    public int Id { get; set; }

    public int WarehouseAdmissionNumber { get; set; }

    public DateTime DateOfAdmission { get; set; }

    public string HostEmployee { get; set; }

    public string SupplierName { get; set; }

    public int OrderNumber { get; set; }

    public string DestinyName { get; set; }

    public string Contract { get; set; }

    public string MaterialName { get; set; }

    public string MaterialType { get; set; }

    public int Quantity { get; set; }

    public string UnitName { get; set; }

    public string NoteFullText { get; set; }
  }
}
