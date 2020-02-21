using log4net;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IExecutor
  {
    List<T> GetListFromDatabase<T>(string storedProcedureName, object parameters);

    T GetFromDatabase<T>(string storedProcedureName, object parameters);

    void GetFromDatabase(string storedProcedureName, object parameters);

    ObservableCollection<T> GetObservableCollectionFromDatabase<T>(string storedProcedureName, object parameters);
  }
}