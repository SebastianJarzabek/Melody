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
  public partial class EditEmployee : UserControl
  {
    private readonly IEmployeesRepository _employeeRepository;

    public EditEmployee(IEmployeesRepository employeeRepository)
    {
      InitializeComponent();
      _employeeRepository = employeeRepository;
    }

    private void UpdateEmployee_panel_Paint(object sender, PaintEventArgs e)
    {
      UpdateEmployee_panel.Location = new Point(
       this.ClientSize.Width / 2 - UpdateEmployee_panel.Size.Width / 2);
      UpdateEmployee_panel.Anchor = AnchorStyles.None;
    }

    private void GeneralClear_btn_Click(object sender, EventArgs e)
    {
      Id_tb.Text = string.Empty;
      Name_tb.Text = string.Empty;
      Surname_tb.Text = string.Empty;
      Departmrnt_tb.Text = string.Empty;
      Position_tb.Text = string.Empty;
    }

    private void LoginDataClear_btn_Click(object sender, EventArgs e)
    {
      Login_tb.Text = string.Empty;
      Password_tb.Text = string.Empty;
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
    private void AddEmployee_btn_Click(object sender, EventArgs e)
    {
      ClearErrorLabel();
      var employee = CollectEmployee();
      var validationResult = employee.Validate();
      try
      {
        if (validationResult.IsValid)
        {
          _employeeRepository.UpdateEmployee(employee);
          MessageBox.Show(  $"Edytowano dane pracownika: {employee.Name} {employee.Surname}.",
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
        MessageBox.Show($"Wystąpił błąd przy Edytowaniu pracownika. {ex}",
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
    private Employee CollectEmployee()
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
        return new Employee
        {
          Id = Id == 0 ? 0 : Id,
          Name = Name_tb.Text,
          Surname = Surname_tb.Text,
          Departament = Departmrnt_tb.Text,
          Position = Position_tb.Text,
          Access = new Access
          {
            Login = Login_tb.Text,
            Password = Password_tb.Text,
          },
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
      Surname_tb.Text = string.Empty;
      Departmrnt_tb.Text = string.Empty;
      Position_tb.Text = string.Empty;
      Login_tb.Text = string.Empty;
      Password_tb.Text = string.Empty;
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
  }
}
