using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IInventoryLevelRepository
  {
    List<InventoryLevelView> GetInventoryLevel();
  }
}