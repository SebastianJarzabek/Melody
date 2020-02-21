using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public class SuppliersRepository : ISuppliersRepository
  {
    private readonly IExecutor _executor;

    public SuppliersRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public List<Supplier> GetSuppliers() => _executor.GetListFromDatabase<Supplier>(new SqlProcedure().GetAllSupplier, null);
  }
}
