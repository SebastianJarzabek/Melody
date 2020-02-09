using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Panel
{
  public partial class AboutMe : UserControl
  {
    public AboutMe()
    {
      InitializeComponent();
    }

    private void AboutMe_panel_Paint(object sender, PaintEventArgs e)
    {
      AboutMe_panel.Location = new Point(
      this.ClientSize.Width / 2 - AboutMe_panel.Size.Width / 2,
      this.ClientSize.Height / 2 - AboutMe_panel.Size.Height / 2);
      AboutMe_panel.Anchor = AnchorStyles.None;
    }
  }
}
