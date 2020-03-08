using Melody.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IWarehouseIssueRepository
  {
    int CheckLastWarehouseIssue();
    object ComboboxSugest(string v1, string v2);
    void AddWarehouseIssue(WarehouseIssue item);
  }
}
