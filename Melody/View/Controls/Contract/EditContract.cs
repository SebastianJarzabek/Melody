using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class EditContract : UserControl
  {
    private readonly IContractsRepository _contractsRepository;

    Destiny destiny = new Destiny();

    public EditContract(IContractsRepository contractsRepository)
    {
      InitializeComponent();
      _contractsRepository = contractsRepository;
    }

    private void EditContract_btn_Click(object sender, EventArgs e)
    {
      ClearErrorLabel();

      try
      {
        var destiny = CollectEmployee();
        var validationResult = destiny.Validate();
        if (validationResult.IsValid)
        {
          _contractsRepository.UpdateDestiny(destiny);
          MessageBox.Show($"Edytowano kontrakt: kontrakt: {destiny.Name} o numerze: {destiny.Contract}.",
                          "Informacja",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
        else
        {
          Validation_lbl.Text = validationResult.ErrorMessageToDisplay;
          MessageBox.Show(validationResult.ErrorMessageToDisplay,
                        "Błąd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);


        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Wystąpił błąd przy edycji kontraktu.",
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

    private Destiny CollectEmployee()
    {
      var destiny = new Destiny();
      destiny.Name = Name_tb.Text;
      destiny.Contract = Contract_tb.Text;
      return destiny;
    }

    private void ClearErrorLabel()
    {
      if (!string.IsNullOrWhiteSpace(Validation_lbl.Text))
      {
        Validation_lbl.Text = string.Empty;
      }
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

    private void UpdateContract_gb_Paint(object sender, PaintEventArgs e)
    {
      EditContract_gb.Location = new Point(
this.ClientSize.Width / 2 - EditContract_gb.Size.Width / 2);
      EditContract_gb.Anchor = AnchorStyles.None;
    }
  }
}
