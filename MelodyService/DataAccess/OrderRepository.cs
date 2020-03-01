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
        orderNumber = order.OrderNumber
    ,
        DateOfOrder = order.DateOfOrder
    ,
        OrderingEmployee = order.OrderingEmployee
    ,
        SupplierName = order.Supplier.Name
    ,
        DestinyName = order.Destiny.Name
    ,
        Contract = order.Destiny.Contract
    ,
        MaterialName = order.Material.Name
    ,
        MaterialType = order.Material.Type
    ,
        Quantity = order.Quantity
    ,
        UnitName = order.Unit.Name
    ,
        NoteFullText = order.Note.NoteFullText
    ,
        ReceivingEmployee = order.ReceivingEmployee
    ,
        PlannedDateOfReceipt = order.PlannedDateOfReceipt
      };
      _executor.InsertIntoDatabase(new SqlProcedure().AddOrder, parameters);
    }

    public void UpdateOrder(Order order)
    {
      var parameters = new
      {
        orderNumber = order.OrderNumber
    ,
        DateOfOrder = order.DateOfOrder
    ,
        OrderingEmployee = order.OrderingEmployee
    ,
        SupplierName = order.Supplier.Name
    ,
        DestinyName = order.Destiny.Name
    ,
        Contract = order.Destiny.Contract
    ,
        MaterialName = order.Material.Name
    ,
        MaterialType = order.Material.Type
    ,
        Quantity = order.Quantity
    ,
        UnitName = order.Unit.Name
    ,
        NoteFullText = order.Note.NoteFullText
    ,
        ReceivingEmployee = order.ReceivingEmployee
    ,
        PlannedDateOfReceipt = order.PlannedDateOfReceipt
      };
      _executor.InsertIntoDatabase(new SqlProcedure().AddDestiny, parameters);
    }

    public void DeleteOrder(Order order)
    {
      var parameters = new
      {
        orderNumber = order.OrderNumber
      };
      _executor.DeleteFromDatabase(new SqlProcedure().DeleteOrder, parameters);
    }

    public List<OrderView> GetOrders()
    {
      return _executor.GetListFromDatabase<OrderView>(new SqlProcedure().GetAllOrder, null);
    }

    public int CheckLast()
    {
      return _executor.CheckLastOrder(new SqlProcedure().LastOrderNumber);
    }

    public DataTable ComboboxSugest(string column, string table)
    {
      return _executor.ComboboxSugest(column, table);
    }
  }
}
