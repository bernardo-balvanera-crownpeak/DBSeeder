using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContextSeed.EntityFramework
{
  /// <summary>
  /// Emulates the Database class from EntityFramework
  /// </summary>
  public class Database
  {
    public void OpenConnection() { }

    public void ExecuteSqlCommand(string cmd) { }

    public void CloseConnection() { }
  }
}
