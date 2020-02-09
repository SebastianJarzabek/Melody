using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melody.View.Panel
{
  public partial class Contact : UserControl
  {
    public Contact()
    {
      InitializeComponent();
    }

    private void Contact_panel_Paint(object sender, PaintEventArgs e)
    {
      Contact_panel.Location = new Point(
      this.ClientSize.Width / 2 - Contact_panel.Size.Width / 2,
      this.ClientSize.Height / 2 - Contact_panel.Size.Height / 2);
      Contact_panel.Anchor = AnchorStyles.None;
    }
  }
}
