﻿using Melody.Service.ConfigService.Interfaces;
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
      return _connectionString;
    }
  }
}
