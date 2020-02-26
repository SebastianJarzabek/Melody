using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;
using Melody.Service.SqlProcedures;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public class InventoryLevelRepository : IInventoryLevelRepository
  {
    private readonly IExecutor _executor;

    public InventoryLevelRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public List<InventoryLevelView> GetInventoryLevel()
    {
      return _executor.GetListFromDatabase<InventoryLevelView>(new SqlProcedure().GetInventoryLevel, null);
    }
  }
}
