using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Melody.View.Controls
{
  public partial class DeleteContract : UserControl
  {
    SqlConnection sqlCon;
    SqlCommand sqlCmd;
    string name = string.Empty;
    string contract = string.Empty;
    public DeleteContract()
    {
      InitializeComponent();
      sqlCon = new SqlConnection("Data Source=SEBASTIAN;Initial Catalog=MelodyDb;Integrated Security=True;");
      sqlCon.Open();
    }
  }
}
