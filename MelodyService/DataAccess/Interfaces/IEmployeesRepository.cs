using Melody.Service.Entity;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public interface IEmployeesRepository
  {
    void AddEmployee(Employee employee);

    void UpdateEmployee(Employee employee);

    void DeleteEmployee(Employee employee);

    List<Employee> GetEmployees();

  }
}