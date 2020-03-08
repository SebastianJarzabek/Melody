using Melody.Service.DataAccess;
using Melody.View.Controls;
using Melody.View.Panel;
using System;
using System.Windows.Forms;

namespace Melody.View.Window
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
    }

    private void Close_msmi_Click(object sender, EventArgs e)
    {
      try
      {
        Application.Exit();
      }
      catch (Exception ex) { throw ex; }
    }

    private void AddSuppliers_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddSuppliersControlPanel = new AddSuppliers(new SuppliersRepository(new Executor()));
        AddSuppliersControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(AddSuppliersControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void UpdateSuppliers_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var UpdateSuppliersControlPanel = new EditSuppliers(new SuppliersRepository(new Executor()));
        UpdateSuppliersControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(UpdateSuppliersControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void ListContractors_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var ListContractorsControlPanel = new ListContractors(new SuppliersRepository(new Executor()));
        ListContractorsControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(ListContractorsControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void DeleteSuppliers_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var DeleteSuppliersControlPanel = new DeleteSuppliers(new SuppliersRepository(new Executor()));
        DeleteSuppliersControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(DeleteSuppliersControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void AddEmployee_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddEmployeeControlPanel = new AddEmployee(new EmployeesRepository(new Executor()));
        AddEmployeeControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(AddEmployeeControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void EditEmployee_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var EditEmployeeControlPanel = new EditEmployee(new EmployeesRepository(new Executor()));
        EditEmployeeControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(EditEmployeeControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void ListEmployee_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var ListEmployeeControlPanel = new ListEmployee(new EmployeesRepository(new Executor()));
        ListEmployeeControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(ListEmployeeControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void DeleteEmployee_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var DeleteEmployeeControlPanel = new DeleteEmployee(new EmployeesRepository(new Executor()));
        DeleteEmployeeControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(DeleteEmployeeControlPanel);

      }
      catch (Exception ex) { throw ex; }
    }

    private void AddContract_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddContractControlPanel = new AddContract_panel(new ContractsRepository(new Executor()));
        AddContractControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(AddContractControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void EditContract_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var EditContractControlPanel = new EditContract(new ContractsRepository(new Executor()));
        EditContractControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(EditContractControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void ListContract_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var ListContractControlPanel = new ListContract(new ContractsRepository(new Executor()));
        ListContractControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(ListContractControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void DeleteContract_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var DeleteContractControlPanel = new DeleteContract(new ContractsRepository(new Executor()));
        DeleteContractControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(DeleteContractControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void AddMaterialReceipt_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddMaterialReceiptControlPanel = new AddWarehouseIssue(new WarehouseIssueRepository(new Executor()));
        AddMaterialReceiptControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(AddMaterialReceiptControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void EditMaterialReceipt_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var EditMaterialReceiptControlPanel = new EditMaterialIssue();
        EditMaterialReceiptControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(EditMaterialReceiptControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void ListMaterialReceipt_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var ListMaterialReceiptControlPanel = new ListMaterialReceipt(new MaterialReceiptRepository(new Executor()));
        ListMaterialReceiptControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(ListMaterialReceiptControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void DeleteMaterialReceipt_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var DeleteMaterialReceiptControlPanel = new DeleteWarehouseAdmission(new MaterialReceiptRepository(new Executor()));
        DeleteMaterialReceiptControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(DeleteMaterialReceiptControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void CurrentState_smi_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var CurrentStateControl = new CurrentState(new InventoryLevelRepository(new Executor()));
        CurrentStateControl.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(CurrentStateControl);
      }
      catch (Exception ex) { throw ex; }
    }

    private void AddMaterialIssue_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddMaterialIssueControlPanel = new AddWarehouseAdmission(new MaterialReceiptRepository(new Executor()));
        AddMaterialIssueControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(AddMaterialIssueControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void EditMaterialIssue_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var EditMaterialIssueControlPanel = new EditMaterialIssue();
        EditMaterialIssueControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(EditMaterialIssueControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void ListMaterialIssue_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var ListMaterialIssueControlPanel = new ListMaterialIssue();
        ListMaterialIssueControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(ListMaterialIssueControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void DeleteMaterialIssue_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var DeleteMaterialIssueControlPanel = new DeleteMaterialIssue();
        DeleteMaterialIssueControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(DeleteMaterialIssueControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void AddOrder_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddOrderControlPanel = new AddOrder(new OrderRepository(new Executor()));
        AddOrderControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(AddOrderControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void EditOrder_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var EditOrderControlPanel = new EditOrder(new OrderRepository(new Executor()));
        EditOrderControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(EditOrderControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void ListOrder_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var ListOrderControlPanel = new ListOrder(new OrderRepository(new Executor()));
        ListOrderControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(ListOrderControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void DeleteOrder_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var DeleteOrderControlPanel = new DeleteOrder(new OrderRepository(new Executor()));
        DeleteOrderControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(DeleteOrderControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void AboutMe_smi_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var aboutMeControl = new AboutMe();
        aboutMeControl.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(aboutMeControl);
      }
      catch (Exception ex) { throw ex; }
    }

    private void Contact_smi_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var contractControl = new Contact();
        contractControl.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(contractControl);
      }
      catch (Exception ex) { throw ex; }
    }
  }
}