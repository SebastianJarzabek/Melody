using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteEmployee : UserControl
  {
    private readonly IEmployeesRepository _employeeRepository;

    public DeleteEmployee(IEmployeesRepository employeeRepository)
    {
      InitializeComponent();
      _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
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

        _employeeRepository.DeleteEmployee(employee);
        MessageBox.Show( $"Usunięto z bazy danych kontrakt: {employee.Name} o numerze: {employee.Surname}.",
                         "Informacja",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Wystąpił błąd przy usuwaniu kontraktu do bazy. {ex}", 
                        "Błąd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        throw ex;
      }
      finally
      {
        Clear();
      }
    }
  }
}
