using Melody.Service.DataAccess;
using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class ListEmployee : UserControl
  {
    private IEmployeesRepository _employeesRepository;
    private List<EmployeeView> _employees;

    public ListEmployee(EmployeesRepository employeesRepository)
    {
      InitializeComponent();
      _employeesRepository = employeesRepository;
      RefereshDestinies();
    }

    private void Refresh_btn_Click(object sender, System.EventArgs e)
    {
      RefereshDestinies();
    }

    private void RefereshDestinies()
    {
      _employees = _employeesRepository.GetEmployees();
      Data_dgv.DataSource = null;
      Data_dgv.DataSource = _employees;
    }
  }
}
