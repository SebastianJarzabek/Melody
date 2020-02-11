using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class ListOrder : UserControl
  {
    public ListOrder()
    {
      InitializeComponent();
    }

    private void Sidebar_panel_Paint(object sender, PaintEventArgs e)
    {
      Sidebar_panel.Controls.Clear();
      var SidebarControlPanel = new Sidebar();
      SidebarControlPanel.Dock = DockStyle.Fill;
      Sidebar_panel.Controls.Add(SidebarControlPanel);
    }

    private void SearchPanel_Paint(object sender, PaintEventArgs e)
    {
      SearchPanel.Location = new Point(
this.ClientSize.Width / 2 - SearchPanel.Size.Width / 2,
this.ClientSize.Height / 2 - SearchPanel.Size.Height / 2);
      SearchPanel.Anchor = AnchorStyles.None;
    }
  }
}
