using Melody.Service.Entity;
using Melody.Service.Entity.EntityToView;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public interface IEmployeesRepository
  {
    void AddEmployee(Employee employee);

    void UpdateEmployee(Employee employee);

    void DeleteEmployee(Employee employee);

    List<EmployeeView> GetEmployees();

  }
}