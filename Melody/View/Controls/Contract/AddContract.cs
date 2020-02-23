using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddContract : UserControl
  {
    private readonly IContractsRepository _contractsRepository;
    private readonly IValidators _validator;

    Destiny destiny = new Destiny();

    public AddContract(IContractsRepository contractsRepository, IValidators validators)
    {
      InitializeComponent();
      _contractsRepository = contractsRepository;
      _validator = validators;
    }

    private void AddContract_btn_Click(object sender, EventArgs e)
    {
      ClearErrorLabel();
      try
      {
        destiny.Name = Name_tb.Text;
        destiny.Contract = Contract_tb.Text;

        if (TbValidate() && ContractValidate())
        {
          _contractsRepository.AddDestiny(destiny);

          MessageBox.Show($"Dodano do bazy danych kontrakt: {destiny.Name} o numerze: {destiny.Contract}.",
                          "Informacja",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }
        else
        {
          return;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Wystąpił błąd przy dodaniu kontraktu do bazy. {ex}",
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

    private bool ContractValidate()
    {
      var destinyErrorMessage = _validator.IsIntContractValidate(destiny);
      if (string.IsNullOrEmpty(destinyErrorMessage))
      {
        return true;
      }
      else
      {
        Validation_lbl.Text = destinyErrorMessage;
        MessageBox.Show(destinyErrorMessage,
        "Błąd",

        MessageBoxButtons.OK,
        MessageBoxIcon.Error);
        return false;
      }
    }

    private bool TbValidate()
    {
      var list = new List<DataClass>
        {
          DataClass.Destiny
        };
      var textBoxesValidateErrorMessage = _validator.TextBoxesValidate(destiny, null, null, list);

      if (string.IsNullOrEmpty(textBoxesValidateErrorMessage))
      {
        return true;
      }
      else
      {
        Validation_lbl.Text = textBoxesValidateErrorMessage;
        MessageBox.Show(textBoxesValidateErrorMessage,
        "Błąd",

        MessageBoxButtons.OK,
        MessageBoxIcon.Error);
        return false;
      }
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

    private void AddContract_gb_Paint(object sender, PaintEventArgs e)
    {
      AddContract_gb.Location = new Point(
      this.ClientSize.Width / 2 - AddContract_gb.Size.Width / 2);
      AddContract_gb.Anchor = AnchorStyles.None;
    }
  }
}
