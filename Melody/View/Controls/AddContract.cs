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
    }
}
