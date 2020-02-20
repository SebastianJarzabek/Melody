using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.SqlProceures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteMaterialReceipt : UserControl
  {
    public DeleteMaterialReceipt()
    {
      InitializeComponent();
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void Clear()
    {
      MaterialReceiptId_tb.Text = string.Empty;
    }

    private void DeleteMaterialReceipt_panel_Paint(object sender, PaintEventArgs e)
    {
      DeleteMaterialReceipt_panel.Location = new Point(
      this.ClientSize.Width / 2 - DeleteMaterialReceipt_panel.Size.Width / 2,
      this.ClientSize.Height / 2 - DeleteMaterialReceipt_panel.Size.Height / 2);
      DeleteMaterialReceipt_panel.Anchor = AnchorStyles.None;

    }

    private void DeleteMaterialReceipt_btn_Click(object sender, EventArgs e)
    {
      try
      {
        var materialReceipt = new WarehouseAdmission()
        {
          IdWarehouseAdmission = Convert.ToInt16(MaterialReceiptId_tb.Text)

        };

        var parameters = new
        {
          idWarehouseIssue = materialReceipt.IdWarehouseAdmission
        };

        var executor = new Executor();
        var execute = new SqlProceure();
        if (executor.DeleteFromDatabase(execute.DeleteWarehouseAdmissionFromId, parameters))
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

