using Melody.Service.Entity;

namespace Melody.Service.Logic
{
  public static class TrimAccessParms
  {
    public static string TrimParms(string toTrimParm)
    {
      return toTrimParm.Trim();
    }

    public static Employee TrimParms(Employee emp)
    {
      emp.Access.Login = emp.Access.Login.Trim();
      emp.Access.Password = emp.Access.Password.Trim();

      return emp;
    }
  }
}