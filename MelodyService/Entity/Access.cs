using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Access
  {
    public int IdAccess { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }
  }
}
