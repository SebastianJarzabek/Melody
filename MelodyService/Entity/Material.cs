using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Material
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Name.Length < 5)
      {
        errorMessages.Add("nazwa materiału, ");
      }

      if (Type.Length < 5)
      {
        errorMessages.Add("typ materiału, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
