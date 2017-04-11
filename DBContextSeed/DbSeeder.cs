using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContextSeed.EntityFramework;

namespace DBContextSeed
{
  public abstract class DbSeeder<T> : IDbSeeder
  {
    private readonly DbSet<T> dbSet;
    protected DbSeeder(DbSet<T> dbSet)
    {
      this.dbSet = dbSet;
    }

    protected DbSet<T> DbSet
    {
      get
      {
        return dbSet;
      }
    }

    protected abstract T[] GetSeedData();

    public virtual void Seed()
    {
      var data = GetSeedData();
      DbSet.AddRange(data);
    }
  }
}
