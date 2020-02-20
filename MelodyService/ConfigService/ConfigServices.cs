using Melody.Service.ConfigService.Interfaces;
using System;
using System.Configuration;

namespace Melody.Service.ConfigService
{
  public class ConfigServices : IConfigServices
  {
    private readonly string _connectionString;

    public ConfigServices()
    {
      _connectionString = ConfigurationManager.ConnectionStrings["MelodyDb"].ConnectionString;
    }

    public string GetConnectionString()
    {
      try
      {
        return _connectionString;
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in ConfigServices.GetConnectionString. " + ex);
      }

    }
  }
}
