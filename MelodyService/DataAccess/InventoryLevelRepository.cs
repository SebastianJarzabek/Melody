using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
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

    public List<InventoryLevel> GetInventoryLevel()
    {
      return _executor.GetListFromDatabase<InventoryLevel>(new SqlProcedure().GetInventoryLevel, null);
    }
    //public List<InventoryLevel> GetInventoryLevel()
    //{
    //  return _executor.GetListFromDatabase<InventoryLevel>(new SqlProcedure().GetInventoryLevel, null);
    //}
    //public List<InventoryLevel> GetInventoryLevel()
    //{
    //  return _executor.GetListFromDatabase<InventoryLevel>(new SqlProcedure().GetInventoryLevel, null);
    //}
  }
}
