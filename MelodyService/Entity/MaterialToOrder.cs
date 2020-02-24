using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class MaterialToOrder
  {
    public int Id { get; set; }

    public Material material { get; set; }

    public Unit unit { get; set; }

    public int Quantity { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (Quantity < 0)
      {
        errorMessages.Add("ilość materiału do zamówienia, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
