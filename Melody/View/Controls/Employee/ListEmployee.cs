using Melody.Service.DataAccess;
using Melody.Service.Logic;
using System.Windows.Forms;

namespace Melody.View.Controls
{
  public partial class ListEmployee : UserControl
  {
    private EmployeesRepository employeesRepository;
    private Validators validators;

    public ListEmployee()
    {
      InitializeComponent();
    }

    public ListEmployee(EmployeesRepository employeesRepository, Validators validators)
    {
      this.employeesRepository = employeesRepository;
      this.validators = validators;
    }
  }
}
