﻿using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.Logic.Interfaces;
using Melody.Service.SqlProcedures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class UpdateSuppliers : UserControl
  {
    private readonly ISuppliersRepository _suppliersRepository;
    private readonly IValidators _validator;

    public UpdateSuppliers(ISuppliersRepository suppliersRepository, IValidators validator)
    {
      InitializeComponent();
      _suppliersRepository = suppliersRepository;
      _validator = validator;
    }

    private void UpdateSuppliers_panel_Paint(object sender, PaintEventArgs e)
    {
      UpdateSuppliers_panel.Location = new Point(
      this.ClientSize.Width / 2 - UpdateSuppliers_panel.Size.Width / 2);
      UpdateSuppliers_panel.Anchor = AnchorStyles.None;
    }


    private void ClearErrorLabel()
    {
      if (string.IsNullOrWhiteSpace(Validation_lbl.Text))
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
      Id_tb.Text = string.Empty;
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
      Id_tb.Text = string.Empty;
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

    private void UpdateSuppliers_btn_Click(object sender, EventArgs e)
    {
      ClearErrorLabel();
      var errorMessage = _validator.IsIntContractValidate(Id_tb.Text, "Id");
      int Id = 0;

      if (string.IsNullOrEmpty(errorMessage))
      {
        Id = Convert.ToInt32(Id_tb.Text);
      }
      else
      {
        throw new Exception(errorMessage);
      }
      var supplier = new Supplier
      {
        Id = Id == 0 ? 0 : Id,
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
        ,DataClass.ContactDetails
      };

      //if (!TextBoxesValidate(supplier, list)
      //  || !PhoneValidate(supplier.ContactDetails.PhoneNumber)
      //  || !EmailValidate(supplier.ContactDetails.Email))
      //{
      //  return;
      //}

      try
      {
        _suppliersRepository.UpdateSupplier(supplier);

        MessageBox.Show($"Edytowano w bazie danych kontrahenta: {supplier.Name}.",
                        "Informacja",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

      }
      catch (Exception ex)
      {
        MessageBox.Show($"Wystąpił błąd przy edycji kontrahenta. {ex}",
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
