using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melody.Service.Entity;
using Melody.Service.DataAccess;
using Melody.Service.SqlProcedures;

namespace Melody.View.Controls
{
  public partial class DeleteContractors : UserControl
  {
    public DeleteContractors()
    {
      InitializeComponent();
    }

    private void DeleteContractor_panel_Paint(object sender, PaintEventArgs e)
    {
      DeleteContractor_panel.Location = new Point(
this.ClientSize.Width / 2 - DeleteContractor_panel.Size.Width / 2,
this.ClientSize.Height / 2 - DeleteContractor_panel.Size.Height / 2);
      DeleteContractor_panel.Anchor = AnchorStyles.None;
    }

    private void DeleteConcractor_btn_Click(object sender, EventArgs e)
    {
      try
      {
        var supplier = new Supplier()
        {
          Name = Name_tb.Text
        };

        var parameters = new
        {
          name = supplier.Name
        };

        var executor = new Executor();
        var execute = new SqlProcedure();
        if (executor.DeleteFromDatabase(execute.DeleteSupplier, parameters))
        {
          Clear();
          MessageBox.Show(
          $"Usunięto z bazy danych kontrahenta: {parameters.name}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Błąd",
          $"Wystąpił błąd przy usuwaniu kontrahenta do bazy. {ex}",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void Clear()
    {
      Name_tb.Text = string.Empty;
    }
  }
}
