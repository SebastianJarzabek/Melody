using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.PasswordCoder;
using Melody.Service.SqlProceures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddEmployee : UserControl
  {
    Validators validators = new Validators();
    public AddEmployee()
    {
      InitializeComponent();

    }

    private void AddEmployee_btn_Click(object sender, EventArgs e)
    {
      TextBoxesValidation_lbl.Text = string.Empty;
      var emp = new Employee
      {
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
        ContactDetails =new ContactDetails
        {
          PhoneNumber=PhoneNumber_tb.Text,
          Email=Email_tb.Text,
          Webside=Webside_tb.Text
        }
      };

      var list = new List<DataClass> 
      {
        DataClass.Employee
        ,DataClass.Access
        ,DataClass.Adress
        ,DataClass.ContactDetails};

      if (!TextBoxesValidate(emp,list)
        || !PhoneValidate(PhoneNumber_tb.Text)
        || !EmailValidate(Email_tb.Text))
      {
        return;
      }

      try
      {
        var parameters = new
        {
          nameIn = emp.Name,
          surnameIn = emp.Surname,
          departamentIn = emp.Departament,
          positionIn = emp.Position,
          loginIn = emp.Access.Login,
          passwordIn = new Coder().CodePassword(emp.Access.Password),
          streetIn = emp.Adress.Street,
          houseNumberIn = emp.Adress.HouseNumber,
          apartmentNumberIn = emp.Adress.ApartmentNumber,
          cityIn = emp.Adress.City,
          zipCodeIn = emp.Adress.ZipCode,
          countryIn = emp.Adress.Country,
          phoneNumberIn = emp.ContactDetails.PhoneNumber,
          emailIn = emp.ContactDetails.Email,
          websideIn = emp.ContactDetails.Webside
        };

        var executor = new Executor();
        var execute = new SqlProceure();
        if (executor.InsertIntoDatabase(execute.AddEmployee, parameters))
        {
          MessageBox.Show(
          $"Dodano do bazy danych pracownika: {parameters.nameIn} {parameters.surnameIn}.",
          "Informacja",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Wystąpił błąd przy dodaniu pracownika do bazy. {ex}",
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

    private bool TextBoxesValidate(Employee emp, List<DataClass> dataClasses)
    {
      var errorMessage = validators.TextBoxesValidate(null,emp, null, dataClasses);

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

    private void GeneralClear_btn_Click(object sender, EventArgs e)
    {
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

    private void AddEmployee_panel_Paint(object sender, PaintEventArgs e)
    {
      AddEmployee_panel.Location = new Point(
       this.ClientSize.Width / 2 - AddEmployee_panel.Size.Width / 2,
       this.ClientSize.Height / 2 - AddEmployee_panel.Size.Height / 2);
      AddEmployee_panel.Anchor = AnchorStyles.None;
    }
  }
}
