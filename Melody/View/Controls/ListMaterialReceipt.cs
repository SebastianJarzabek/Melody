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
  public partial class ListMaterialReceipt : UserControl
  {
    public ListMaterialReceipt()
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
  }
}
