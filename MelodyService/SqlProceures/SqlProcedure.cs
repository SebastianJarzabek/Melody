using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.SqlProcedures
{

  [ExcludeFromCodeCoverage]
  public class SqlProcedure
  {
    public string GetAllSupplier => "dbo.GetAllSupplier";

    public string GetAllEmployee => "dbo.GetAllEmployee";

    public string GetInventoryLevel => "dbo.GetInventoryLevel";

    public string UsersLogin => "dbo.UsersLogin";

    public string AddDestiny => "dbo.AddDestiny";

    public string AddEmployee => "dbo.AddEmployee";

    public string AddMaterial => "dbo.AddMaterial";

    public string AddOrder => "dbo.AddOrder";

    public string AddSupplier => "dbo.AddSupplier";

    public string AddUnit => "dbo.AddUnit";

    public string AddWarehouseAdmission => "dbo.AddWarehouseAdmission";

    public string AddWarehouseIssue => "dbo.AddWarehouseIssue";

    public string DeleteDestiny => "dbo.DeleteDestiny";

    public string DeleteEmployee => "dbo.DeleteEmployee";

    public string DeleteMaterial => "dbo.DeleteMaterial";

    public string DeleteOrder => "dbo.DeleteOrder";

    public string DeleteSupplier => "dbo.DeleteSupplier";

    public string DeleteUnit => "dbo.DeleteUnit";

 

    public string DeleteWarehouseAdmissionFromId => "dbo.DeleteWarehouseAdmissionFromId";

    public string DeleteWarehouseIssueFromId => "dbo.DeleteWarehouseIssueFromId";

    public string GetAllOrder => "dbo.GetAllOrder";

    public string GetAllWarehouseIssue => "dbo.GetAllWarehouseIssue";

    public string GetAllWarehouseIssueFromId => "dbo.GetAllWarehouseIssueFromId";

    public string GetAllWarehouseAdmission => "dbo.GetAllWarehouseAdmission";
    public string GetDestiny => "dbo.GetDestiny";

    public string GetDestinyFromId => "dbo.GetDestinyFromId";

    public string GetEmployee => "dbo.GetEmployee";

    public string GetMaterialFromId => "dbo.GetMaterialFromId";

    public string GetOrderFromId => "dbo.GetOrderFromId";

    public string GetSupplierFromId => "dbo.GetSupplierFromId";

    public string GetUnitFromId => "dbo.GetUnitFromId";

    public string UpdateDestiny => "dbo.UpdateDestiny";

    public string UpdateEmployee => "dbo.UpdateEmployee";

    public string UpdateMaterial => "dbo.UpdateMaterial";

    public string UpdateOrder => "dbo.UpdateOrder";

    public string UpdateQuantityInventoryLevel => "dbo.UpdateQuantityInventoryLevel";

    public string UpdateSupplier => "dbo.UpdateSupplier";

    public string UpdateUnit => "dbo.UpdateUnit";

    public string UpdateWarehouseAdmission => "dbo.UpdateWarehouseAdmission";

    public string UpdateWarehouseIssue => "dbo.UpdateWarehouseIssue";

    public string GetDestinies => "dbo.GetAllDestiny";

    public string OnInit => "dbo.OnInit";

    public string LastOrderNumber => "dbo.LastOrderNumber";
  }
}