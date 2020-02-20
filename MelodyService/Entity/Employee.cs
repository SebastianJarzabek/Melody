using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Employee
  {
    public int IdEmployee { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Departament { get; set; }

    public string Position { get; set; }

    public Access Access { get; set; }

    public ContactDetails ContactDetails { get; set; }

    public Adress Adress { get; set; }

  }
}
