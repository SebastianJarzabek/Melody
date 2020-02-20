using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class ContactDetails
  {
    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string Webside { get; set; }
  }
}
