using log4net;
using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.Logic;
using Melody.Service.PasswordCoder;
using Melody.Service.SqlProceures;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Melody.View.Window
{
  public partial class Login : Form
  {
    private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    public Login()
    {
      InitializeComponent();
    }

    private void Login_panel_Paint(object sender, PaintEventArgs e)
    {
      Login_panel.Location = new Point(
      this.ClientSize.Width / 2 - Login_panel.Size.Width / 2,
      this.ClientSize.Height / 2 - Login_panel.Size.Height / 2);
      Login_panel.Anchor = AnchorStyles.None;
    }

    private void Login_btn_Click(object sender, EventArgs e)
    {
      string codePassword = string.Empty;

      if (!string.IsNullOrWhiteSpace(LoginValidation_lbl.Text)
        || !string.IsNullOrWhiteSpace(PasswordValidation_lbl.Text))
      {
        LoginValidation_lbl.Text = string.Empty;
        PasswordValidation_lbl.Text = string.Empty;
      }

      try
      {
        if (string.IsNullOrWhiteSpace(Login_tb.Text) ||
          string.IsNullOrWhiteSpace(Password_tb.Text))
        {
          if (string.IsNullOrWhiteSpace(Login_tb.Text))
          {
            LoginValidation_lbl.Text = "Login nie może być pusty!";
          }
          if (string.IsNullOrWhiteSpace(Password_tb.Text))
          {
            PasswordValidation_lbl.Text = "Hasło nie może być puste!";
          }
          MessageBox.Show("Pola logowania nie mogą być puste!",
          "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
          return;
        }
        var PasswordToPrepared = TrimAccessParms.TrimPassword(Password_tb.Text);
        if (PasswordToPrepared != "admin")
        {
          var coder = new Coder();
          codePassword = coder.CodePassword(PasswordToPrepared);
        }

        var emp = new Employee
        {
          Access = new Access()
          {
            Login = Login_tb.Text,
            Password = string.IsNullOrEmpty(codePassword) ? PasswordToPrepared : codePassword,
          }
        };
        TrimAccessParms.TrimParms(emp);

        var parameters = new { loginInparm = emp.Access.Login, passwordInParm = emp.Access.Password };
        var loginExec = new Executor();
        var sqlProceures = new SqlProceure();

        if (loginExec.GetFromDatabase<bool>(Log, sqlProceures.UsersLogin, parameters))
        {
          var MainForm = new Main();
          MainForm.Show();
          this.Visible = false;
        }
        else
        {
          MessageBox.Show($"Dane podane podczas logowania dla {emp.Access.Login} nie istnieją. Sprawdź poprawność danych i spróbój ponownie.",
            "Błąd logowania",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Wystąpił błąd. {ex}",
          "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw;
      }
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Login_tb.Text = "";
      Password_tb.Text = "";
    }

    private void Close_btn_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}