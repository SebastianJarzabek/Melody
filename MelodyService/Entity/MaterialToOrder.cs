using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class MaterialToOrder
  {
    public Material material { get; set; }

    public Unit unit { get; set; }

    public int Quantity { get; set; }
  }
}
