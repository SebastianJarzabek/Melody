using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteSuppliers : UserControl
  {
    private readonly ISuppliersRepository _suppliersRepository;

    public DeleteSuppliers(ISuppliersRepository suppliersRepository)
    {
      InitializeComponent();
      _suppliersRepository = suppliersRepository;
    }

    private void DeleteContractor_panel_Paint(object sender, PaintEventArgs e)
    {
      DeleteContractor_panel.Location = new Point(
this.ClientSize.Width / 2 - DeleteContractor_panel.Size.Width / 2);
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
        _suppliersRepository.DeleteSupplier(supplier);
        Clear();
        MessageBox.Show($"Usunięto z bazy danych kontrahenta: {supplier.Name}.",
                        "Informacja",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Wystąpił błąd przy usuwaniu kontrahenta do bazy. {ex}", 
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
