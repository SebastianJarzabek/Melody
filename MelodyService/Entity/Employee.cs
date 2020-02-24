using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Employee
  {
    public Employee()
    {
      Access = new Access();
      ContactDetails = new ContactDetails();
      Adress = new Adress();
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Departament { get; set; }

    public string Position { get; set; }

    public Access Access { get; set; }

    public ContactDetails ContactDetails { get; set; }

    public Adress Adress { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Name.Length < 5)
      {
        errorMessages.Add("Imie, ");
      }

      if (Surname.Length < 5)
      {
        errorMessages.Add("Nazwisko, ");
      }

      if (Departament.Length < 5)
      {
        errorMessages.Add("dział, ");
      }

      if (Position.Length < 5)
      {
        errorMessages.Add("stanowisko, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
