using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteWarehouseAdmission : UserControl
  {
    private readonly IMaterialReceiptRepository _materialReceiptRepository;
    public DeleteWarehouseAdmission(IMaterialReceiptRepository materialReceiptRepository )
    {
      InitializeComponent();
      _materialReceiptRepository = materialReceiptRepository ?? throw new ArgumentNullException(nameof(materialReceiptRepository));
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
        var warehouseAdmission = new WarehouseAdmission()
        {
          WarehouseAdmissionNumber = Convert.ToInt16(MaterialReceiptNumber_tb.Text)
        };


        _materialReceiptRepository.DeleteWarehouseAdmission(warehouseAdmission);
        MessageBox.Show(
        $"Usunięto z bazy danych przyjęcie na magazyn o numerze: {warehouseAdmission.WarehouseAdmissionNumber}.",
        "Informacja",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show(
          $"Wystąpił błąd przy usuwaniu przyjęcia na magazyn./n{ex}", "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
      finally
      {
        Clear();
      }
    }
    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void Clear()
    {
      MaterialReceiptNumber_tb.Text = string.Empty;
    }
  }
}

