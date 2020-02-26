using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.Service.DataAccess
{
  public class OrderRepository : IOrderRepository
  {
    private readonly IExecutor _executor;
    public OrderRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public void AddDestiny(Order order)
    {
      var parameters = new
      {

      }
      _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parameters);
    }

    public void UpdateDestiny(Order order)
    {
      int Contract = Convert.ToInt32(destiny.Contract);
      var parameters = new { destiny.Name, Contract };

      _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parameters);
    }

    public void DeleteDestiny(Order order)
    {
      object parameters;

      if (!string.IsNullOrEmpty(order.Contract))
      {
        var Contract = Convert.ToInt32(order.Contract);
        parameters = new { order.Name, Contract };
      }
      else
      {
        parameters = new { order.Name };
      }
      _executor.DeleteFromDatabase(new SqlProcedure().DeleteDestiny, parameters);
    }

    public List<Destiny> GetDestinies()
    {
      return _executor.GetListFromDatabase<Destiny>(new SqlProcedure().GetDestinies, null);
    }
  }
}
