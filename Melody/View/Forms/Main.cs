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
      Application.Exit();
    }

    private void AddContractors_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var AddContractorsControlPanel = new AddContractors();
      AddContractorsControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(AddContractorsControlPanel);
    }

    private void EditContractors_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var EditContractorsControlPanel = new EditContractors();
      EditContractorsControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(EditContractorsControlPanel);
    }

    private void ListContractors_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var ListContractorsControlPanel = new ListContractors();
      ListContractorsControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(ListContractorsControlPanel);
    }

    private void DeleteContractors_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var DeleteContractorsControlPanel = new DeleteContractors();
      DeleteContractorsControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(DeleteContractorsControlPanel);
    }

    private void AddEmployee_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var AddEmployeeControlPanel = new AddEmployee();
      AddEmployeeControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(AddEmployeeControlPanel);
    }

    private void EditEmployee_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var EditEmployeeControlPanel = new EditEmployee();
      EditEmployeeControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(EditEmployeeControlPanel);
    }

    private void ListEmployee_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var ListEmployeeControlPanel = new ListEmployee();
      ListEmployeeControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(ListEmployeeControlPanel);
    }

    private void DeleteEmployee_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var DeleteEmployeeControlPanel = new DeleteEmployee();
      DeleteEmployeeControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(DeleteEmployeeControlPanel);
    }

    private void AddContract_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var AddContractControlPanel = new AddContract(new ContractsRepository(new Executor()), new Validators());
      AddContractControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(AddContractControlPanel);
    }

    private void EditContract_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var EditContractControlPanel = new EditContract(new ContractsRepository(new Executor()), new Validators());
      EditContractControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(EditContractControlPanel);
    }

    private void ListContract_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var ListContractControlPanel = new ListContract(new ContractsRepository(new Executor()));
      ListContractControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(ListContractControlPanel);
    }

    private void DeleteContract_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var DeleteContractControlPanel = new DeleteContract(new ContractsRepository(new Executor()), new Validators());
      DeleteContractControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(DeleteContractControlPanel);
    }

    private void AddMaterialReceipt_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var AddMaterialReceiptControlPanel = new AddWarehouseIssue();
      AddMaterialReceiptControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(AddMaterialReceiptControlPanel);
    }

    private void EditMaterialReceipt_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var EditMaterialReceiptControlPanel = new EditMaterialReceipt();
      EditMaterialReceiptControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(EditMaterialReceiptControlPanel);
    }

    private void ListMaterialReceipt_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var ListMaterialReceiptControlPanel = new ListMaterialReceipt();
      ListMaterialReceiptControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(ListMaterialReceiptControlPanel);
    }

    private void DeleteMaterialReceipt_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var DeleteMaterialReceiptControlPanel = new DeleteMaterialReceipt();
      DeleteMaterialReceiptControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(DeleteMaterialReceiptControlPanel);
    }

    private void CurrentState_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var CurrentStateControl = new CurrentState_panel();
      CurrentStateControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(CurrentStateControl);
    }

    private void AddMaterialIssue_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var AddMaterialIssueControlPanel = new AddWarehouseAdmission();
      AddMaterialIssueControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(AddMaterialIssueControlPanel);
    }

    private void EditMaterialIssue_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var EditMaterialIssueControlPanel = new EditMaterialIssue();
      EditMaterialIssueControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(EditMaterialIssueControlPanel);
    }

    private void ListMaterialIssue_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var ListMaterialIssueControlPanel = new ListMaterialIssue();
      ListMaterialIssueControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(ListMaterialIssueControlPanel);
    }

    private void DeleteMaterialIssue_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var DeleteMaterialIssueControlPanel = new DeleteMaterialIssue();
      DeleteMaterialIssueControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(DeleteMaterialIssueControlPanel);
    }

    private void AddOrder_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var AddOrderControlPanel = new AddOrder();
      AddOrderControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(AddOrderControlPanel);
    }

    private void EditOrder_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var EditOrderControlPanel = new EditOrder();
      EditOrderControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(EditOrderControlPanel);
    }

    private void ListOrder_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var ListOrderControlPanel = new ListOrder();
      ListOrderControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(ListOrderControlPanel);
    }

    private void DeleteOrder_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var DeleteOrderControlPanel = new DeleteOrder();
      DeleteOrderControlPanel.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(DeleteOrderControlPanel);
    }

    private void AboutMe_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var aboutMeControl = new AboutMe();
      aboutMeControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(aboutMeControl);
    }

    private void Contact_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var contractControl = new Contact();
      contractControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(contractControl);
    }
  }
}
