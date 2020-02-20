using Melody.Service.Entity;
using Melody.Service.Logic.Interfaces;
using System;
using System.Text;

namespace Melody.Service.Logic
{
  public class QueryBuilder : IQueryBuilder
  {
    public string BuildLoginQuery(string query, Employee emp)
    {
      try
      {
        var stb = new StringBuilder();
        stb.Append(query);
        stb.Append(" '");
        stb.Append(emp.Access.Login);
        stb.Append("', '");
        stb.Append(emp.Access.Password);
        stb.Append("'");
        stb.Append(query);
        return stb.ToString();
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in BuildQuery." + ex);
      }
    }
  }
}
