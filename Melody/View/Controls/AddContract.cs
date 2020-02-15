using Melody.Service.DataAccess;
using Melody.Service.SqlProceures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddContract : UserControl
  {
    public AddContract()
    {
      InitializeComponent();
    }

    private void AddContract_gb_Paint(object sender, EventArgs e)
    {
      AddContract_gb.Location = new Point(
      this.ClientSize.Width / 2 - AddContract_gb.Size.Width / 2,
      this.ClientSize.Height / 2 - AddContract_gb.Size.Height / 2);
      AddContract_gb.Anchor = AnchorStyles.None;
    }

    private void AddContract_btn_Click(object sender, EventArgs e)
    {
      string ValidatedContract = null;

      if (!string.IsNullOrWhiteSpace(NameValidation_lbl.Text)
        || !string.IsNullOrWhiteSpace(ContractValidation_lbl.Text))
      {
        NameValidation_lbl.Text = string.Empty;
        ContractValidation_lbl.Text = string.Empty;
      }

      try
      {
        if (string.IsNullOrWhiteSpace(Name_tb.Text)
        || string.IsNullOrWhiteSpace(Contract_tb.Text))
        {
          if (string.IsNullOrWhiteSpace(Name_tb.Text))
          {
            NameValidation_lbl.Text = "Nazwa nie może być pusta";
          }
          if (string.IsNullOrWhiteSpace(Contract_tb.Text))
          {
            ContractValidation_lbl.Text = "Numer Kontraktu nie może być pusty";
          }
          MessageBox.Show("Pola nie mogą być puste!",
          "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
          return;
        }

        if (IsIntContractValidate(Contract_tb.Text))
        {
          ValidatedContract = Contract_tb.Text;
        }
        else
        {
          ContractValidation_lbl.Text = "Numer Kontraktu\nmoże zawierać jedynie liczby.";
          MessageBox.Show("Numer Kontraktu musi zawierać jedynie cyfry oraz być dłuższy niż cztery znaki np. 1234.",
          "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
          return;
        }

        var parameters = new
        {
          name = Name_tb.Text,
          contract = ValidatedContract,
        };

        var executor = new Executor();
        var execute = new SqlProceure();
        if (executor.InsertIntoDatabase(execute.AddDestiny, parameters))
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
        MessageBox.Show("Błąd",
          $"Wystąpił błąd przy dodaniu kontraktu do bazy. {ex}",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Name_tb.Text = "";
      Contract_tb.Text = "";
    }

    private bool IsIntContractValidate(string contract)
    {
      if (contract.Length >= 4)
      {
        return int.TryParse(contract, out int result);
      }
      else
        return false;
    }
  }
}
