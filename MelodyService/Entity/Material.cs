using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Material
  {
    public int IdMaterial { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }
  }
}
