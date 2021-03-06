﻿using Dapper;
using log4net;
using Melody.Service.ConfigService;
using Melody.Service.ConfigService.Interfaces;
using Melody.Service.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Melody.Service.DataAccess
{
  [ExcludeFromCodeCoverage]
  public class Executor : IExecutor
  {
    private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly IConfigServices _configService;
    
    public Executor()
    {
      _configService = new ConfigServices();
    }

    public ObservableCollection<T> GetObservableCollectionFromDatabase<T>(string storedProcedureName, object parameters)
    {
      var result = GetListFromDatabase<T>(storedProcedureName, parameters);
      return new ObservableCollection<T>(result);
    }

    public List<T> GetListFromDatabase<T>(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          var pom = connection.Query<T>(storedProcedureName, parameters, null, true, null, commandType: CommandType.StoredProcedure).ToList();
          return pom;
        }
      }
      catch (Exception ex)
      {
        log.Error(ex);
        throw;
      }
    }

    public T GetFromDatabase<T>(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          return connection.Query<T>("UsersLogin", parameters, null, true, null, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
      }
      catch (Exception ex)
      {
        log.Error(ex);
        throw;
      }
    }

    public int CheckLastOrder(string storedProcedureName)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          var pom = connection.ExecuteScalar(storedProcedureName);
          return Convert.ToInt32(pom);
        }
      }
      catch (Exception ex)
      {
        log.Error(ex);
        throw;
      }
    }

    public void GetFromDatabase(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          connection.Query<dynamic>(storedProcedureName, parameters, null, true, null, commandType: CommandType.StoredProcedure);
        }
      }
      catch (Exception ex)
      {
        log.Error(ex);
        throw;
      }
    }

    public void InsertIntoDatabase(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        { 
          connection.Query(storedProcedureName, parameters, null, true, null, commandType: CommandType.StoredProcedure).ToList();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public void DeleteFromDatabase(string storedProcedureName, object parameters)
    {
      try
      {
        using (var connection = new SqlConnection(_configService.GetConnectionString()))
        {
          connection.Query(storedProcedureName, parameters, null, true, null, commandType: CommandType.StoredProcedure).ToList();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public DataTable ComboboxSugest(string column, string table)
    {
      SqlConnection sqlconnection = new SqlConnection(_configService.GetConnectionString());
      sqlconnection.Open();

      SqlCommand sqlCommand = new SqlCommand($"SELECT DISTINCT [{column}] FROM MelodyDb.dbo.{table} ORDER BY [{column}] ASC", sqlconnection);

      SqlDataReader reader;
      reader = sqlCommand.ExecuteReader();
      DataTable datatable = new DataTable();
      datatable.Columns.Add(column, typeof(string));
      datatable.Load(reader);
      sqlconnection.Close();
      return datatable;
    }

    private bool IsSuccess(int result)
    {
      if (result >= 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}