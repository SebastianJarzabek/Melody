using Melody.Service.DataAccess;
using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class ListOrder : UserControl
  {
    private IOrderRepository _orderRepository;
    private List<OrderView> orders;

    public ListOrder(OrderRepository orderRepository)
    {
      InitializeComponent();
      _orderRepository = orderRepository;
      RefresesOrder();
    }

    private void RefresesOrder()
    {
      orders = _orderRepository.GetOrders();
      Data_dgv.DataSource = null;
      Data_dgv.DataSource = orders;
    }

    private void Refresh_btn_Click(object sender, System.EventArgs e)
    {
      RefresesOrder();
    }
  }
}
