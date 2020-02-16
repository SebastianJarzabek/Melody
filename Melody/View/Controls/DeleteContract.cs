using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.SqlProceures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteContract : UserControl
  {
    public DeleteContract()
    {
      InitializeComponent();
    }

    private void DeleteContract_panel_Paint(object sender, PaintEventArgs e)
    {
      DeleteContract_panel.Location = new Point(
      this.ClientSize.Width / 2 - DeleteContract_panel.Size.Width / 2,
      this.ClientSize.Height / 2 - DeleteContract_panel.Size.Height / 2);
      DeleteContract_panel.Anchor = AnchorStyles.None;
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Clear();

    }

    private void Clear()
    {
      Name_tb.Text = string.Empty;
      Contract_tb.Text = string.Empty;
    }

    private void DeleteConcract_btn_Click(object sender, EventArgs e)
    {
      try
      {
        var destiny = new Destiny()
        {
          Name = Name_tb.Text,
          Contract = Contract_tb.Text
        };

        var parameters = new
        {
          name = destiny.Name,
          contract = destiny.Contract,
        };

        var executor = new Executor();
        var execute = new SqlProceure();
        if (executor.DeleteFromDatabase(execute.DeleteDestiny, parameters))
        {
          Clear();
          MessageBox.Show(
          $"Usunięto z bazy danych kontrakt: {parameters.name} o numerze: {parameters.contract}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        }
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
