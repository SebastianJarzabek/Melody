using Melody.Service.DataAccess;
using Melody.Service.Entity;
using Melody.Service.SqlProcedures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteOrder : UserControl
  {
    public DeleteOrder()
    {
      InitializeComponent();
    }

        private void DeleteOrder_panel_Paint(object sender, PaintEventArgs e)
        {
      DeleteOrder_panel.Location = new Point(
      this.ClientSize.Width / 2 - DeleteOrder_panel.Size.Width / 2);
      DeleteOrder_panel.Anchor = AnchorStyles.None;
    }

    private void DeleteOrder_btn_Click(object sender, EventArgs e)
    {
      try
      {
        var order = new Order()
        {
          IdOrder = Convert.ToInt16(OrderNumber_tb.Text)
        };

        var parameters = new
        {
          name = order.IdOrder
        };

        var executor = new Executor();
        var execute = new SqlProcedure();
        //if (executor.DeleteFromDatabase(execute.DeleteDestiny, parameters))
        //{
        //  Clear();
        //  MessageBox.Show(
        //  $"Usunięto z bazy danych kontrakt: {parameters.name}.",
        //  "Informacja",
        //  MessageBoxButtons.OK,
        //  MessageBoxIcon.Information);
        //}
      }
      catch (Exception ex)
      {
        MessageBox.Show("Błąd",
          $"Wystąpił błąd przy usuwaniu kontraktu do bazy. {ex}",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
    }

    private void Clear_btn_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void Clear()
    {
      OrderNumber_tb.Text = string.Empty;
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
