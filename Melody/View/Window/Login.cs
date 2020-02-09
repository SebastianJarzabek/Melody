using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Window
{
  public partial class Login : Form
  {
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
      var Main = new Main();
      Main.Show();
      this.Visible = false;
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Login_tb.Text = "";
      Password_tb.Text = "";
    }

    private void Close_btn_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
