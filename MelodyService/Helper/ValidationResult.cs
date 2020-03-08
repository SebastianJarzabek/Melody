using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Melody.Service.Helper
{
  public class ValidationResult
  {
    public ValidationResult()
    {
      ErrorMessages = new List<string>();
    }

    public List<string> ErrorMessages { get; set; }

    public bool IsValid => !ErrorMessages.Any();

    public string ErrorMessageToDisplay
    {
      get
      {
        var sb = new StringBuilder();
        sb.AppendLine("Proszę poprawić dane: ");
        foreach (var errorMessage in ErrorMessages)
        {
          sb.Append("- ");
          sb.AppendLine(errorMessage);
        }
        return sb.ToString();
      }
    }
  }
}
