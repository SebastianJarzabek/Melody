using System.Collections.Generic;
using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;

namespace Melody.Service.DataAccess
{
  public class ContractsRepository  : IContractsRepository
  {
    private readonly IExecutor _executor;

    public ContractsRepository(IExecutor executor)
    {
      _executor = executor;
    }


    public List<Destiny> GetDestinies()
    {
      return _executor.GetListFromDatabase<Destiny>(new SqlProcedure().GetDestinies,null);
    }
  }
}
