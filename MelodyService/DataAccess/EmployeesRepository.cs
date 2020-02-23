using Melody.Service.DataAccess.Interfaces;
using Melody.Service.Entity;
using Melody.Service.PasswordCoder;
using Melody.Service.SqlProcedures;
using System.Collections.Generic;

namespace Melody.Service.DataAccess
{
  public class EmployeesRepository : IEmployeesRepository
  {
    private readonly IExecutor _executor;
    public EmployeesRepository(IExecutor executor)
    {
      _executor = executor;
    }

    public void AddEmployee(Employee employee)
    {
      var parameters = new
      {
        nameIn = employee.Name,
        surnameIn = employee.Surname,
        departamentIn = employee.Departament,
        positionIn = employee.Position,
        loginIn = employee.Access.Login,
        passwordIn = new Coder().CodePassword(employee.Access.Password),
        streetIn = employee.Adress.Street,
        houseNumberIn = employee.Adress.HouseNumber,
        apartmentNumberIn = employee.Adress.ApartmentNumber,
        cityIn = employee.Adress.City,
        zipCodeIn = employee.Adress.ZipCode,
        countryIn = employee.Adress.Country,
        phoneNumberIn = employee.ContactDetails.PhoneNumber,
        emailIn = employee.ContactDetails.Email,
        websideIn = employee.ContactDetails.Webside
      };

      _executor.InsertIntoDatabase(new SqlProcedure().AddEmployee, parameters);
    }

    public void UpdateEmployee(Employee employee)
    {
      var parameters = new
      {
        Id = employee.Id,
        nameIn = employee.Name,
        surnameIn = employee.Surname,
        departamentIn = employee.Departament,
        positionIn = employee.Position,
        loginIn = employee.Access.Login,
        passwordIn = new Coder().CodePassword(employee.Access.Password),
        streetIn = employee.Adress.Street,
        houseNumberIn = employee.Adress.HouseNumber,
        apartmentNumberIn = employee.Adress.ApartmentNumber,
        cityIn = employee.Adress.City,
        zipCodeIn = employee.Adress.ZipCode,
        countryIn = employee.Adress.Country,
        phoneNumberIn = employee.ContactDetails.PhoneNumber,
        emailIn = employee.ContactDetails.Email,
        websideIn = employee.ContactDetails.Webside
      };

      _executor.InsertIntoDatabase(new SqlProcedure().UpdateEmployee, parameters);
    }

    public void DeleteEmployee(Employee employee)
    {
      var parameters = new
      {
        nameIn = employee.Name,
        surnameIn = employee.Surname,
      };
      
      _executor.DeleteFromDatabase(new SqlProcedure().DeleteEmployee, parameters);
    }

    public List<Employee> GetEmployees()
    {
      return _executor.GetListFromDatabase<Employee>(new SqlProcedure().GetAllEmployee, null);
    }
  }
}
