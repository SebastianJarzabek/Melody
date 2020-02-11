using log4net;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Melody.Service.DataAccess.Interfaces
{
  public interface IExecutor
  {
    List<T> GetListFromDatabase<T>(ILog log, string storedProcedureName, object parameters);

    T GetFromDatabase<T>(ILog log, string storedProcedureName, object parameters);

    void GetFromDatabase(ILog log, string storedProcedureName, object parameters);

    ObservableCollection<T> GetObservableCollectionFromDatabase<T>(ILog log, string storedProcedureName, object parameters);
  }
}