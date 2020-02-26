
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.Service.Entity.EntityToView
{
  public class InventoryLevelView
  {
    public int Id { get; set; }

    public string MaterialName { get; set; }

    public string MaterialType { get; set; }

    public int Quantity { get; set; }

    public string UnitName { get; set; }
  }
}
