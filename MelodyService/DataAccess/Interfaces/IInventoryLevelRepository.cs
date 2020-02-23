using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IInventoryLevelRepository
  {
    List<InventoryLevel> GetInventoryLevel();
  }
}