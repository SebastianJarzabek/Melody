using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Unit
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Name.Length < 5)
      {
        errorMessages.Add("j.m, ");
      }
      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
