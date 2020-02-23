using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.SqlProcedures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class EditContract : UserControl
  {
    Validators validators = new Validators();
    public EditContract()
    {
      InitializeComponent();
    }

    private void EditContract_btn_Click(object sender, EventArgs e)
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

        var executor = new Executor();
        var execute = new SqlProcedure();
    executor.InsertIntoDatabase(execute.UpdateDestiny, parameters);
       
          MessageBox.Show(
          $"Edytowano kontrakt: {parameters.name} o numerze: {parameters.contract}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
     
      }
      catch (Exception ex)
      {
        MessageBox.Show("Błąd",
          $"Wystąpił błąd przy edycji kontraktu. {ex}",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
    }

    private void Clear_btn_Click(object sender, EventArgs e)
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
