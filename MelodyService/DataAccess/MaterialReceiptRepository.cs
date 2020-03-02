using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;
using Melody.Service.SqlProcedures;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public class MaterialReceiptRepository : IMaterialReceiptRepository
  {
    private readonly IExecutor _executor;
    public MaterialReceiptRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public void AddWarehouseAdmission(WarehouseAdmission item)
    {
      _executor.CheckLastOrder(new SqlProcedure().AddWarehouseAdmission);
    }

    public int CheckLast()
    {
      return _executor.CheckLastOrder(new SqlProcedure().LastWarehouseAdmission);
    }

    public object ComboboxSugest(string column, string table)
    {
      return _executor.ComboboxSugest(column, table);
    }

    public void DeleteWarehouseAdmission(WarehouseAdmission warehouseAdmission)
    {
      var parameters = new
      {
        WarehouseAdmissionNumber = warehouseAdmission.WarehouseAdmissionNumber
      };
      _executor.DeleteFromDatabase(new SqlProcedure().DeleteWarehouseAdmissionFromId, parameters);
    }

    public List<MaterialReceiptView> GetWarehouseAdmission()
    {
      return _executor.GetListFromDatabase<MaterialReceiptView>(new SqlProcedure().GetAllWarehouseAdmission, null);
    }

    public void UpdateWarehouseAdmission(WarehouseAdmission warehouseAdmission)
    {
      _executor.CheckLastOrder(new SqlProcedure().UpdateWarehouseAdmission);
    }
  }
}
