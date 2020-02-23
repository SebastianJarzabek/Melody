using Melody.Service.DataAccess;
using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.Logic.Interfaces;
using Melody.Service.SqlProcedures;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteContract : UserControl
  {
    private readonly IContractsRepository _contractsRepository;
    private readonly IValidators _validator;

    Destiny destiny = new Destiny();

    public DeleteContract(IContractsRepository contractsRepository, IValidators validators)
    {
      InitializeComponent();

      _contractsRepository = contractsRepository;
      _validator = validators;
    }

    private void DeleteContract_panel_Paint(object sender, PaintEventArgs e)
    {
      DeleteContract_panel.Location = new Point(
      this.ClientSize.Width / 2 - DeleteContract_panel.Size.Width / 2);
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

        destiny.Name = Name_tb.Text;
        destiny.Contract = Contract_tb.Text;

        _contractsRepository.DeleteDestinies(destiny);

        Clear();
        var stb = new StringBuilder();
        stb.Append($"Usunięto z bazy danych ");
        if (!string.IsNullOrWhiteSpace(destiny.Name))
        {
          stb.Append($"kontrakt: { destiny.Name}");
        }
        if (!string.IsNullOrWhiteSpace(destiny.Contract))
        {
          stb.Append($" o numerze: {destiny.Contract}");
        }
        stb.Append(".");
        
        MessageBox.Show(stb.ToString(),
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
