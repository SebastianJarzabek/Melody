namespace Melody.Service.Entity
{
  public class Employee
  {
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }

    public string Departament { get; set; }

    public string Position { get; set; }

    public Access Access { get; set; }

    public Adress Adress { get; set; }

    public ContactDetails ContactDetails { get; set; }
  }
}
