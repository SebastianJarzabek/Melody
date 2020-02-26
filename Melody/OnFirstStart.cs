using Melody.Service.DataAccess;
using Melody.Service.SqlProcedures;

namespace Melody
{
  static public class OnFirstStart
  {
    public static void InitAccess()
    {
      var init = new Executor();
      var parameters = new
      {
        Login = "admin",
        Password = "admin"
      };
      init.InsertIntoDatabase(new SqlProcedure().OnInit, parameters);
    }
  }
}
