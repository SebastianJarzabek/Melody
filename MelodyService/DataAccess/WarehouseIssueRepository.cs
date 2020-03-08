using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.Service.DataAccess
{
  public class WarehouseIssueRepository : IWarehouseIssueRepository
  {
    private readonly IExecutor _executor;
    public WarehouseIssueRepository(IExecutor executor)
    {
      _executor = executor ?? throw new ArgumentNullException(nameof(executor));
    }

    public void AddWarehouseIssue(WarehouseIssue item)
    {
      throw new NotImplementedException();
    }

    public int CheckLastWarehouseIssue()
    {
      throw new NotImplementedException();
    }

    public object ComboboxSugest(string v1, string v2)
    {
      throw new NotImplementedException();
    }
  }
}
