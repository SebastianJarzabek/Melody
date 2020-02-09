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
      var contractControl = new Contract();
      contractControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(contractControl);
    }

    private void Contract_msmi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var contractControl = new Contract();
      contractControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(contractControl);
    }

    private void Contractor_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var contractorControl = new Contract();
      contractorControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(contractorControl);
    }

    private void CurrentState_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var currentStateControl = new CurrentState();
      currentStateControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(currentStateControl);
    }

    private void Employees_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var employeeControl = new Employee();
      employeeControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(employeeControl);
    }

    private void MaterialIssue_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var materialIssueControl = new MaterialIssue(); 
      materialIssueControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(materialIssueControl);
    }

    private void MaterialRecipt_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var materialReceiptControl = new MaterialRecipt();
      materialReceiptControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(materialReceiptControl);
    }

    private void Order_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var orderControl = new Order();
      orderControl.Dock = DockStyle.Fill;
      Main_Panel.Controls.Add(orderControl);
      
    }



    private void AddContractors_Click(object sender, EventArgs e)
    {

    }

    private void EditContractors_Click(object sender, EventArgs e)
    {

    }

    private void ListContractors_Click(object sender, EventArgs e)
    {

    }

    private void DeleteContractors_Click(object sender, EventArgs e)
    {

    }

    private void Close_msmi_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Main_Panel_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
