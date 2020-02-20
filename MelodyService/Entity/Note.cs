using System.Diagnostics.CodeAnalysis;

namespace Melody.Service.Entity
{
  [ExcludeFromCodeCoverage]
  public class Note
  {
    public int IdNote { get; set; }

    public string NoteFullText { get; set; }
  }
}
