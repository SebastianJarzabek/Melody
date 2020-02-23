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
  public partial class AddContractors : UserControl
  {
    Validators validators = new Validators();
    public AddContractors()
    {
      InitializeComponent();
    }

    private void AddContractors_panel_Paint(object sender, PaintEventArgs e)
    {
      AddContractors_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddContractors_panel.Size.Width / 2);
      AddContractors_panel.Anchor = AnchorStyles.None;
    }

    private void AddContractors_btn_Click(object sender, EventArgs e)
    {
      TextBoxesValidation_lbl.Text = string.Empty;
      var contractor = new Supplier
      {
        Name = Name_tb.Text,
        Adress = new Adress
        {
          Street = Street_tb.Text,
          HouseNumber = HouseNumber_tb.Text,
          ApartmentNumber = ApartamentNumber_tb.Text,
          City = City_tb.Text,
          ZipCode = ZipCode_tb.Text,
          Country = Country_tb.Text
        },
        ContactDetails = new ContactDetails
        {
          PhoneNumber = PhoneNumber_tb.Text,
          Email = Email_tb.Text,
          Webside = Webside_tb.Text
        }
      };

      var list = new List<DataClass>
      {
        DataClass.Supplier
        ,DataClass.Adress
        ,DataClass.ContactDetails};

      if (!TextBoxesValidate(contractor, list)
        || !PhoneValidate(contractor.ContactDetails.PhoneNumber)
        || !EmailValidate(contractor.ContactDetails.Email))
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
        var execute = new SqlProcedure();
        executor.InsertIntoDatabase(execute.AddSupplier, parameters);
        
          MessageBox.Show(
          $"Dodano do bazy danych kontrahenta: {parameters.name}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        
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
      var errorMessage = validators.PhoneValidate(PhoneNumber_tb.Text);

      if (string.IsNullOrEmpty(errorMessage))
      {
        return true;
      }
      else
      {
        MessageBox.Show(errorMessage, "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        TextBoxesValidation_lbl.Text = errorMessage;
        return false;
      }
    }

    private bool EmailValidate(string email)
    {
      var errorMessage = validators.EmailValidate(Email_tb.Text);

      if (string.IsNullOrEmpty(errorMessage))
      {
        return true;
      }
      else
      {
        MessageBox.Show(errorMessage, "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        TextBoxesValidation_lbl.Text = errorMessage;
        return false;
      }
    }

    private bool TextBoxesValidate(Supplier contractor, List<DataClass> dataClasses)
    {
      var errorMessage = validators.TextBoxesValidate(null, null, contractor, dataClasses);

      if (string.IsNullOrEmpty(errorMessage))
      {
        return true;
      }
      else
      {
        MessageBox.Show(errorMessage, "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        TextBoxesValidation_lbl.Text = errorMessage;
        return false;
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
