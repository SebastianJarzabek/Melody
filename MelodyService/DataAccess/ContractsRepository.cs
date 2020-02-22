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


    public bool AddDestiny(object parm)
    {
      return _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parm);
    }

    public bool UpdateDestinies(object parm)
    {
      return _executor.InsertIntoDatabase(new SqlProcedure().UpdateDestiny, parm);
    }

    public bool DeleteDestinies(object parm)
    {
      return _executor.DeleteFromDatabase(new SqlProcedure().DeleteDestiny, parm);
    }

    public List<Destiny> GetDestinies()
    {
      return _executor.GetListFromDatabase<Destiny>(new SqlProcedure().GetDestinies, null);
    }
  }
}
