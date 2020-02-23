using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddSuppliers : UserControl
  {
    private readonly ISuppliersRepository _suppliersRepository;
    private readonly IValidators _validator;

    public AddSuppliers(ISuppliersRepository suppliersRepository, IValidators validator)
    {
      InitializeComponent();
      _suppliersRepository = suppliersRepository;
      _validator = validator;
    }

    private void AddSuppliers_panel_Paint(object sender, PaintEventArgs e)
    {
      AddSuppliers_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddSuppliers_panel.Size.Width / 2);
      AddSuppliers_panel.Anchor = AnchorStyles.None;
    }

    private void AddSuppliers_btn_Click(object sender, EventArgs e)
    {
      ClearErrorLabel();

      var supplier = new Supplier
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



      //// [TODO] -> błąd walidacji (obiekt emp a supplier) w validators 
      //if (!TextBoxesValidate(supplier, list)
      //  || !PhoneValidate(supplier.ContactDetails.PhoneNumber)
      //  || !EmailValidate(supplier.ContactDetails.Email))
      //{
      //  return;
      //}

      try
      {
        _suppliersRepository.AddSupplier(supplier);

        MessageBox.Show($"Dodano do bazy danych kontrahenta: {supplier.Name}.",
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
      finally
      {
        Clear();
      }
    }

    private void ClearErrorLabel()
    {
      if (!string.IsNullOrWhiteSpace(Validation_lbl.Text))
      {
        Validation_lbl.Text = string.Empty;
      }
    }

    private bool PhoneValidate(string phoneNumber)
    {
      var errorMessage = _validator.PhoneValidate(PhoneNumber_tb.Text);

      if (string.IsNullOrEmpty(errorMessage))
      {
        return true;
      }
      else
      {
        MessageBox.Show(errorMessage, "Błąd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        Validation_lbl.Text = errorMessage;
        return false;
      }
    }

    private bool EmailValidate(string email)
    {
      var errorMessage = _validator.EmailValidate(Email_tb.Text);

      if (string.IsNullOrEmpty(errorMessage))
      {
        return true;
      }
      else
      {
        MessageBox.Show(errorMessage, "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        Validation_lbl.Text = errorMessage;
        return false;
      }
    }

    private bool TextBoxesValidate(Supplier supplier, List<DataClass> dataClasses)
    {
      var errorMessage = _validator.TextBoxesValidate(null, null, supplier, dataClasses);

      if (string.IsNullOrEmpty(errorMessage))
      {
        return true;
      }
      else
      {
        MessageBox.Show(errorMessage, "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        Validation_lbl.Text = errorMessage;
        return false;
      }
    }

    private void Clear()
    {
      Name_tb.Text = string.Empty;
      PhoneNumber_tb.Text = string.Empty;
      Email_tb.Text = string.Empty;
      Webside_tb.Text = "Brak";
      Street_tb.Text = string.Empty;
      HouseNumber_tb.Text = string.Empty;
      ApartamentNumber_tb.Text = "0";
      City_tb.Text = string.Empty;
      ZipCode_tb.Text = string.Empty;
      Country_tb.Text = string.Empty;
    }

    private void GeneralClear_btn_Click(object sender, EventArgs e)
    {

      Name_tb.Text = string.Empty;
    }

    private void ClearContact_btn_Click(object sender, EventArgs e)
    {
      PhoneNumber_tb.Text = string.Empty;
      Email_tb.Text = string.Empty;
      Webside_tb.Text = "Brak";
    }

    private void AdressClear_btn_Click(object sender, EventArgs e)
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
