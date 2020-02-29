using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;
using Melody.Service.SqlProcedures;
using System;
using System.Collections.Generic;
using System.Data;

namespace Melody.Service.DataAccess
{
  public class OrderRepository : IOrderRepository
  {
    private readonly IExecutor _executor;
    public OrderRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public void AddOrder(Order order)
    {
      var parameters = new
      {

      };

      _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parameters);
    }

    public void UpdateOrder(Order order)
    {
      var parameters = new
      {

      };
      _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parameters);
    }

    public void DeleteOrder(Order order)
    {
      var parameters = new
      {

      };
      _executor.DeleteFromDatabase(new SqlProcedure().DeleteDestiny, parameters);
    }

    public List<OrderView> GetOrders()
    {
      return _executor.GetListFromDatabase<OrderView>(new SqlProcedure().GetDestinies, null);
    }

    public int CheckLast()
    {
      return _executor.GetFromDatabase<int>(new SqlProcedure().LastOrderNumber, null);
    }

    public DataTable ComboboxSugest(string column, string table)
    {
      return _executor.ComboboxSugest(column, table);
    }
  }
}
