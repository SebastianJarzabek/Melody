using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;
using System.Data;

namespace Melody.Service.DataAccess
{
  public interface IOrderRepository
  {
    void AddOrder(Order order);

    void UpdateOrder(Order order);

    void DeleteOrder(Order order);

    List<OrderView> GetOrders();

    DataTable ComboboxSugest(string column, string table);

    int CheckLast();
  }
}