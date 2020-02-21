using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteMaterialIssue : UserControl
  {
    public DeleteMaterialIssue()
    {
      InitializeComponent();
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void Clear()
    {
      MaterialIssueId_tb.Text = string.Empty;
    }

    private void DeleteMaterialIssue_panel_Paint(object sender, PaintEventArgs e)
    {
      DeleteMaterialIssue_panel.Location = new Point(
this.ClientSize.Width / 2 - DeleteMaterialIssue_panel.Size.Width / 2,
this.ClientSize.Height / 2 - DeleteMaterialIssue_panel.Size.Height / 2);
      DeleteMaterialIssue_panel.Anchor = AnchorStyles.None;

    }

    private void DeleteMaterialIssue_btn_Click(object sender, EventArgs e)
    {
      try
      {
        var warehouseIssue = new WarehouseIssue()
        {
          IdWarehouseIssue = Convert.ToInt16(MaterialIssueId_tb.Text)

        };

        var parameters = new
        {
          idWarehouseIssue = warehouseIssue.IdWarehouseIssue
        };

        var executor = new Executor();
        var execute = new SqlProcedure();
        if (executor.DeleteFromDatabase(execute.DeleteWarehouseIssueFromId, parameters))
        {
          Clear();
          MessageBox.Show(
          $"Usunięto z bazy danych  : {parameters.idWarehouseIssue}.",
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
