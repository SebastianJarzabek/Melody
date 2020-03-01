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

    public void DeleteMaterialReceipt(WarehouseAdmission warehouseAdmission)
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

  }
}
