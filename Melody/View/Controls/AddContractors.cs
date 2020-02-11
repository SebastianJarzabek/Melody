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
  public partial class AddContractors : UserControl
  {
    public AddContractors()
    {
      InitializeComponent();
    }

    private void AddContractors_panel_Paint(object sender, PaintEventArgs e)
    {
      AddContractors_panel.Location = new Point(
      this.ClientSize.Width / 2 - AddContractors_panel.Size.Width / 2,
      this.ClientSize.Height / 2 - AddContractors_panel.Size.Height / 2);
      AddContractors_panel.Anchor = AnchorStyles.None;
    }
  }
}
