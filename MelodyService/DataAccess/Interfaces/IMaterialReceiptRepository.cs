using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IMaterialReceiptRepository
  {
    void DeleteMaterialReceipt(WarehouseAdmission warehouseAdmission);

    List<MaterialReceiptView> GetWarehouseAdmission();

    int CheckLast();

    void AddWarehouseAdmission(WarehouseAdmission item);

    object ComboboxSugest(string column, string table);
  }
}