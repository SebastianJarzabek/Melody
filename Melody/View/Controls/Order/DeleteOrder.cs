using Melody.Service.DataAccess;
using Melody.Service.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class DeleteOrder : UserControl
  {
    private readonly IOrderRepository _orderRepository;
    public DeleteOrder(IOrderRepository orderRepository)
    {
      InitializeComponent();
      _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
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
          OrderNumber = Convert.ToInt16(OrderNumber_tb.Text)
        };


        _orderRepository.DeleteOrder(order);
        MessageBox.Show(
        $"Usunięto z bazy danych kontrakt: {order.OrderNumber}.",
        "Informacja",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

      }
      catch (Exception ex)
      {
        MessageBox.Show(
          $"Wystąpił błąd przy usuwaniu kontraktu do bazy. {ex}", "Błąd",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
        throw ex;
      }
      finally
      {
        Clear();
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
  }
}
