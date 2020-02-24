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
  public partial class EditSuppliers : UserControl
  {
    private readonly ISuppliersRepository _suppliersRepository;

    public EditSuppliers(ISuppliersRepository suppliersRepository)
    {
      InitializeComponent();
      _suppliersRepository = suppliersRepository;
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

      var supplier = CollectSupplier();
      var validationResult = supplier.Validate();
      try
      {
        if (validationResult.IsValid)
        {
          _suppliersRepository.UpdateSupplier(supplier);

          MessageBox.Show($"Edytowano w bazie danych kontrahenta: {supplier.Name}.",
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
    private Supplier CollectSupplier()
    {
      int Id = 0;
      if (string.IsNullOrEmpty(Id_tb.Text))
      {
        MessageBox.Show("Pole Id musi zostać uzupełnione!");
        return null;
      }
      else
      {
        Id = Convert.ToInt32(Id_tb.Text);
        return new Supplier
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
      }
    }
  }
}