using Melody.Service.Helper;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Note
  {
    public int Id { get; set; }

    public string NoteFullText { get; set; }

    public ValidationResult Validate()
    {
      var errorMessages = new List<string>();
      if (NoteFullText.Length < 5)
      {
        errorMessages.Add("uwagi, ");
      }

      return new ValidationResult
      {
        ErrorMessages = errorMessages
      };
    }
  }
}
