using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteEmployee : UserControl
  {
    public DeleteEmployee()
    {
      InitializeComponent();
    }

    private void DeleteEmployee_panel_Paint(object sender, PaintEventArgs e)
    {
      DeleteEmployee_panel.Location = new Point(
this.ClientSize.Width / 2 - DeleteEmployee_panel.Size.Width / 2);
      DeleteEmployee_panel.Anchor = AnchorStyles.None;
    }
    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Clear();

    }

    private void Clear()
    {
      Name_tb.Text = string.Empty;
      Surname_tb.Text = string.Empty;
    }

    private void DeleteConcract_btn_Click(object sender, EventArgs e)
    {
      try
      {
        var employee = new Employee()
        {
          Name = Name_tb.Text,
          Surname = Surname_tb.Text
        };

        var parameters = new
        {
          nameIn   = employee.Name,
          surnameIn = employee.Surname,
        };

        var executor = new Executor();
        var execute = new SqlProcedure();
        executor.DeleteFromDatabase(execute.DeleteEmployee, parameters);
        
          Clear();
          MessageBox.Show(
          $"Usunięto z bazy danych kontrakt: {parameters.nameIn} o numerze: {parameters.surnameIn}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        
      }
      catch (Exception ex)
      {
        MessageBox.Show("Błąd",
          $"Wystąpił błąd przy usuwaniu kontraktu do bazy. {ex}",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
    }
  }
}
