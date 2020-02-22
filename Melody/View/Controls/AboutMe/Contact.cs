using System.Drawing;
using System.Windows.Forms;

namespace Melody.View.Panel
{
  public partial class Contact : UserControl
  {
    public Contact()
    {
      InitializeComponent();
    }

    private void ContactChild_palen_Paint(object sender, PaintEventArgs e)
    {
      ContactChild_palen.Location = new Point(
      this.ClientSize.Width / 2 - ContactChild_palen.Size.Width / 2,
      this.ClientSize.Height / 2 - ContactChild_palen.Size.Height / 2);
      ContactChild_palen.Anchor = AnchorStyles.None;
    }
  }
}
