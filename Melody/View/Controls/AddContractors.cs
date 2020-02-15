using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melody.Service.DataAccess;
using Melody.Service.SqlProceures;

namespace Melody.View.Controls
{
  public partial class AddContractors : UserControl
  {
    public AddContractors()
    {
      InitializeComponent();
    }

    private void AddContractors_panel_Paint(object sender, PaintEventArgs e)
    {
      AddContractors_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddContractors_panel.Size.Width / 2,
      this.ClientSize.Height / 2 - AddContractors_panel.Size.Height / 2);
      AddContractors_panel.Anchor = AnchorStyles.None;
    }

    private void AddContractors_btn_Click(object sender, EventArgs e)
    {
      if (!TextBoxesValidate()
        || !PhoneValidate(PhoneNumber_tb.Text)
        || !EmailValidate(Email_tb.Text))
      {
        return;
      }

      try
      {
        var parameters = new
        {
          name = Name_tb.Text,
          streetIn = Street_tb.Text,
          houseNumberIn = HouseNumber_tb.Text,
          apartmentNumberIn = ApartamentNumber_tb.Text,
          cityIn = City_tb.Text,
          zipCodeIn = ZipCode_tb.Text,
          countryIn = Country_tb.Text,
          phoneNumberIn = PhoneNumber_tb.Text,
          emailIn = Email_tb.Text,
          websideIn = Webside_tb.Text
        };

        var executor = new Executor();
        var execute = new SqlProceure();
        if (executor.InsertIntoDatabase(execute.AddSupplier, parameters))
        {
          MessageBox.Show(
          $"Dodano do bazy danych kontrahenta: {parameters.name}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Wystąpił błąd przy dodaniu kontrahenta do bazy. {ex}",
          "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
    }

    private bool PhoneValidate(string phoneNumber)
    {
      if (int.TryParse(phoneNumber, out int result))
      {
        return true;
      }
      else
      {
        var errorMessage = "Nieprawidłowy format numeru telefonu.\nNumer powinien sie składać tylko cyfr.";
        MessageBox.Show(errorMessage, "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        TextBoxesValidation_lbl.Text = errorMessage;
        return false;
      }
    }

    private bool EmailValidate(string email)
    {
      if (email.Contains("@") && email.Contains("."))
      {
        return true;
      }
      else
      {
        var errorMessage = $"Nieprawidłowy format adresu email.\nNumer powinien zwierać @ i .";
        MessageBox.Show(errorMessage, "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        TextBoxesValidation_lbl.Text = errorMessage;
        return false;
      }
    }

    private bool TextBoxesValidate()
    {
      if (string.IsNullOrEmpty(Name_tb.Text)
        || string.IsNullOrEmpty(PhoneNumber_tb.Text)
        || string.IsNullOrEmpty(Email_tb.Text)
        || string.IsNullOrEmpty(Webside_tb.Text)
        || string.IsNullOrEmpty(Street_tb.Text)
        || string.IsNullOrEmpty(HouseNumber_tb.Text)
        || string.IsNullOrEmpty(ApartamentNumber_tb.Text)
        || string.IsNullOrEmpty(City_tb.Text)
        || string.IsNullOrEmpty(ZipCode_tb.Text)
        || string.IsNullOrEmpty(Country_tb.Text)
        )
      {
        var stb = new StringBuilder();
        stb.AppendLine("Pole:");

        if (string.IsNullOrEmpty(Name_tb.Text))
        {
          stb.AppendLine(" nazwa,");
        }
        if (string.IsNullOrEmpty(PhoneNumber_tb.Text))
        {
          stb.AppendLine(" numer telefonu,");
        }
        if (string.IsNullOrEmpty(Email_tb.Text))
        {
          stb.AppendLine(" e-mail,");
        }
        if (string.IsNullOrEmpty(Webside_tb.Text))
        {
          stb.AppendLine(" strona internetowa,");
        }
        if (string.IsNullOrEmpty(Street_tb.Text))
        {
          stb.AppendLine(" ulica,");
        }
        if (string.IsNullOrEmpty(HouseNumber_tb.Text))
        {
          stb.AppendLine(" numer domu,");
        }
        if (string.IsNullOrEmpty(ApartamentNumber_tb.Text))
        {
          stb.AppendLine(" numer lokalu,");
        }
        if (string.IsNullOrEmpty(City_tb.Text))
        {
          stb.AppendLine(" miasto,");
        }
        if (string.IsNullOrEmpty(ZipCode_tb.Text))
        {
          stb.AppendLine(" kod-pocztowy,");
        }
        if (string.IsNullOrEmpty(Country_tb.Text))
        {
          stb.AppendLine(" kraj,");
        }
        stb.Remove(stb.Length - 1, 1);
        stb.AppendLine("musi zostać uzupełnione.");
        MessageBox.Show(stb.ToString(), "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        TextBoxesValidation_lbl.Text = stb.ToString();
        return false;
      }
      else
      {
        return true;
      }
    }

    private void ClearGeneral_btn_Click(object sender, EventArgs e)
    {
      Name_tb.Text = string.Empty;
    }

    private void ClearContact_btn_Click(object sender, EventArgs e)
    {
      PhoneNumber_tb.Text = string.Empty;
      Email_tb.Text = string.Empty;
      Webside_tb.Text = "Brak";
    }

    private void ClearAdress_btn_Click(object sender, EventArgs e)
    {
      Street_tb.Text = string.Empty;
      HouseNumber_tb.Text = string.Empty;
      ApartamentNumber_tb.Text = "0";
      City_tb.Text = string.Empty;
      ZipCode_tb.Text = string.Empty;
      Country_tb.Text = string.Empty;
    }
  }
}
