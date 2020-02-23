using System;
using System.Collections.Generic;
using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;

namespace Melody.Service.DataAccess
{
  public class ContractsRepository : IContractsRepository
  {
    private readonly IExecutor _executor;

    public ContractsRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public void AddDestiny(Destiny destiny)
    {
      int Contract = Convert.ToInt32(destiny.Contract);
      var parameters = new { destiny.Name, Contract };

      _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parameters);
    }

    public void UpdateDestiny(Destiny destiny)
    {
      int Contract = Convert.ToInt32(destiny.Contract);
      var parameters = new { destiny.Name, Contract };

      _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parameters);
    }

    public void DeleteDestiny(Destiny destiny)
    {
      object parameters;

      if (!string.IsNullOrEmpty(destiny.Contract))
      {
        var Contract = Convert.ToInt32(destiny.Contract);
        parameters = new { destiny.Name, Contract };
      }
      else
      {
        parameters = new { destiny.Name };
      }
      _executor.DeleteFromDatabase(new SqlProcedure().DeleteDestiny, parameters);
    }

    public List<Destiny> GetDestinies()
    {
      return _executor.GetListFromDatabase<Destiny>(new SqlProcedure().GetDestinies, null);
    }
  }
}
