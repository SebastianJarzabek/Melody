using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Supplier
  {
    public int IdSupplier { get; set; }

    public string Name { get; set; }

    public Adress Adress { get; set; }

    public ContactDetails ContactDetails { get; set; }
  }
}
