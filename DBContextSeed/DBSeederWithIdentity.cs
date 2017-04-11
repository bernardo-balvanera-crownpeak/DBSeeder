using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContextSeed.EntityFramework;

namespace DBContextSeed
{
  /// <summary>
  /// A DbSeeder that will enable IDENTITY_INSERT when seeding data.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <seealso cref="DBContextSeed.DbSeeder{T}" />
  /// <seealso cref="System.IDisposable" />
  public abstract class DBSeederWithIdentity<T> : DbSeeder<T>, IDisposable
  {
    private readonly string tableName;
    private readonly Database database;
    protected DBSeederWithIdentity(DbSet<T> dbSet, string tableName, Database database) : base(dbSet)
    {
      if (string.IsNullOrWhiteSpace(tableName))
      {
        throw new ArgumentException($"{nameof(tableName)} cannot be null", nameof(tableName));
      }

      if (database == null)
      {
        throw new ArgumentNullException($"{nameof(database)} cannot be null", nameof(database));
      }

      this.tableName = tableName;
      this.database  = database;

      SetIdentityInsertOn();
    }

    protected virtual void SetIdentityInsertOn()
    {
      database.OpenConnection();
      database.ExecuteSqlCommand($"SET IDENTITY_INSERT [dbo].[{tableName}] ON GO;");
      // I believe no need to call SaveChanges is necessary here thanks to the GO command above.
      database.CloseConnection();
    }

    protected virtual void SetIdentityInsertOff()
    {
      database.OpenConnection();
      database.ExecuteSqlCommand($"SET IDENTITY_INSERT [dbo].[{tableName}] OFF GO;");
      // I believe no need to call SaveChanges is necessary here thanks to the GO command above.
      database.CloseConnection();
    }

    public void Dispose()
    {
      Dispose(true);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        SetIdentityInsertOff();
      }
    }
  }
}
