using Melody.View.Controls;
using Melody.View.Panel;
using System;
using System.Windows.Forms;
using Melody.Service.DataAccess;
using Melody.Service.Logic;

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

    private void AddContractors_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddContractorsControlPanel = new AddContractors();
        AddContractorsControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(AddContractorsControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void EditContractors_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var EditContractorsControlPanel = new EditContractors();
        EditContractorsControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(EditContractorsControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void ListContractors_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var ListContractorsControlPanel = new ListContractors();
        ListContractorsControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(ListContractorsControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void DeleteContractors_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var DeleteContractorsControlPanel = new DeleteContractors();
        DeleteContractorsControlPanel.Dock = DockStyle.Fill;
        Main_Panel.Controls.Add(DeleteContractorsControlPanel);
      }
      catch (Exception ex) { throw ex; }
    }

    private void AddEmployee_Click(object sender, EventArgs e)
    {
      try
      {
        Main_Panel.Controls.Clear();
        var AddEmployeeControlPanel = new AddEmployee(new EmployeesRepository(new Executor()), new Validators());
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
        var EditEmployeeControlPanel = new EditEmployee(new EmployeesRepository(new Executor()), new Validators());
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
        var DeleteEmployeeControlPanel = new DeleteEmployee(new EmployeesRepository(new Executor()), new Validators());
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
        var AddContractControlPanel = new AddContract(new ContractsRepository(new Executor()), new Validators());
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
        var EditContractControlPanel = new EditContract(new ContractsRepository(new Executor()), new Validators());
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
        var DeleteContractControlPanel = new DeleteContract(new ContractsRepository(new Executor()), new Validators());
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
        var AddMaterialReceiptControlPanel = new AddWarehouseIssue();
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
        var EditMaterialReceiptControlPanel = new EditMaterialReceipt();
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
        var ListMaterialReceiptControlPanel = new ListMaterialReceipt();
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
        var DeleteMaterialReceiptControlPanel = new DeleteMaterialReceipt();
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
        var CurrentStateControl = new CurrentState( new InventoryLevelRepository(new Executor()));
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
        var AddMaterialIssueControlPanel = new AddWarehouseAdmission();
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
        var AddOrderControlPanel = new AddOrder();
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
        var EditOrderControlPanel = new EditOrder();
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
        var ListOrderControlPanel = new ListOrder();
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
        var DeleteOrderControlPanel = new DeleteOrder();
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