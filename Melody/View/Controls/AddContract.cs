using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.SqlProceures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class AddContract : UserControl
  {
    public AddContract()
    {
      InitializeComponent();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
      groupBox1.Location = new Point(
      this.ClientSize.Width / 2 - groupBox1.Size.Width / 2,
      this.ClientSize.Height / 2 - groupBox1.Size.Height / 2);
      groupBox1.Anchor = AnchorStyles.None;
    }

    private void AddContract_btn_Click(object sender, EventArgs e)
    {
      try
      {
        if (!string.IsNullOrWhiteSpace(Name_tb.Text) || !string.IsNullOrWhiteSpace(Contract_tb.Text))
        {
          var parameters = new
          {
            name = Name_tb.Text,
            contract = Contract_tb.Text,
          };

          var executor = new Executor();
          var execute = new SqlProceure();
          executor.InsertIntoDatabase(execute.AddDestiny, parameters);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Błąd",
          $"Wystąpił błąd przy dodaniu kontraktu do bazy. {ex}",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);

        throw ex;
      }


    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Name_tb.Text = "";
      Contract_tb.Text = "";
    }
  }
}
