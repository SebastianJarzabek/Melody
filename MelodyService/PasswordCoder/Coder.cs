using Melody.Service.PasswordCoder.Interfaces;

namespace Melody.Service.PasswordCoder
{
  public class Coder : ICoder
  {
    private string _accessCodeParm = string.Empty;
    private string _accessUnCodeParm = string.Empty;

    public Coder()
    {
    }

    public string CodePassword(string password)
    {
      var _accessCodeParm = System.Text.Encoding.UTF8.GetBytes(password);
      return System.Convert.ToBase64String(_accessCodeParm);
    }

    public string uncodePassword(string password)
    {
      var _accessUnCodeParm = System.Text.Encoding.UTF8.GetBytes(password);
      return System.Convert.ToBase64String(_accessUnCodeParm);
    }
  }
}