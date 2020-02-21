using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melody.Service.DataAccess;
using Melody.Service.SqlProcedures;

namespace Melody.View.Panel
{
  public partial class CurrentState_panel : UserControl
  {
    public CurrentState_panel()
    {
      InitializeComponent();
    }

    private void CurrentState_panel_Load(object sender, EventArgs e)
    {
      var exec = new Executor();
      var sqlProc = new SqlProcedure();
      var dataTable = exec.GetFromDatabase(sqlProc.GetInventoryLevel);

    }
  }
}
