using Melody.Service.DataAccess;
using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.SqlProcedures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddContract : UserControl
  {
    private readonly IContractsRepository _contractsRepository;
    Validators validators = new Validators();

    public AddContract(IContractsRepository contractsRepository)
    {
      InitializeComponent();
      _contractsRepository = contractsRepository;
    }

    private void AddContract_btn_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(Validation_lbl.Text))
      {
        Validation_lbl.Text = string.Empty;
      }

      try
      {
        var destiny = new Destiny()
        {
          Name = Name_tb.Text,
          Contract = Contract_tb.Text
        };

        var list = new List<DataClass>
        {
          DataClass.Destiny
        };
        var textBoxesValidateErrorMessage = validators.TextBoxesValidate(destiny, null, null, list);
        
        if (!string.IsNullOrEmpty(textBoxesValidateErrorMessage))
        {
          Validation_lbl.Text = textBoxesValidateErrorMessage;
          MessageBox.Show(textBoxesValidateErrorMessage,
          "Błąd",
         
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
          return;
        }

        var destinyErrorMessage = validators.IsIntContractValidate(destiny);
        if (!string.IsNullOrEmpty(destinyErrorMessage))
        {
          Validation_lbl.Text = destinyErrorMessage;
          MessageBox.Show(destinyErrorMessage,
          "Błąd",
          
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
          return;
        }

        var parameters = new
        {
          name = destiny.Name,
          contract = destiny.Contract,
        };
        
        if (_contractsRepository.AddDestiny(parameters))
        {
          MessageBox.Show(
          $"Dodano do bazy danych kontrakt: {parameters.name} o numerze: {parameters.contract}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
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
