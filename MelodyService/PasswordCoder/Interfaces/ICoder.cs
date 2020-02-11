namespace Melody.Service.PasswordCoder.Interfaces
{
  public interface ICoder
  {
    string CodePassword(string password);

    string uncodePassword(string password);
  }
}