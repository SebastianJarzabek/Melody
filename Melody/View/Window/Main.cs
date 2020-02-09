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
      Main_Panel.Controls.Add(aboutMeControl);
    }

    private void Contact_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var contractControl = new Contract();
      Main_Panel.Controls.Add(contractControl);
    }

    private void Contract_msmi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var contractControl = new Contract();
      Main_Panel.Controls.Add(contractControl);
    }

    private void Contractor_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var contractsControl = new Contract();
      Main_Panel.Controls.Add(contractsControl);
    }

    private void CurrentState_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var currentStateControl = new CurrentState();
      Main_Panel.Controls.Add(currentStateControl);
    }

    private void Employees_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var contractsControl = new Contract();
      Main_Panel.Controls.Add(contractsControl);
    }

    private void MaterialIssue_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var materialIssueControl = new MaterialIssue();
      Main_Panel.Controls.Add(materialIssueControl);
    }

    private void MaterialRecipt_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var materialReceiptControl = new MaterialRecipt();
      Main_Panel.Controls.Add(materialReceiptControl);
    }

    private void Order_smi_Click(object sender, EventArgs e)
    {
      Main_Panel.Controls.Clear();
      var orderControl = new Order();
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
  }
}
