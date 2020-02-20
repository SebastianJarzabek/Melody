namespace Melody.Service.PasswordCoder.Interfaces
{
  public interface ICoder
  {
    string CodePassword(string password);

    string UncodePassword(string password);
  }
}