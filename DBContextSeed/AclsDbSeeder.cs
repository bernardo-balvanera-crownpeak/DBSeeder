using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContextSeed.EntityFramework;
using DBContextSeed.Models;

namespace DBContextSeed
{

  /// <summary>
  /// An example of a Seeder who doesn't need to issue a IDENTITY_INSERT command
  /// </summary>
  /// <seealso cref="DBContextSeed.DbSeeder{DBContextSeed.Models.Acls}" />
  public class AclsDbSeeder : DbSeeder<Acls>
  {
    public AclsDbSeeder(DbSet<Acls> dbSet) : base(dbSet)
    {
    }

    /// <summary>
    /// Gets the seed data.
    /// </summary>
    /// <returns>The actual data required to seed this table in particular.</returns>
    protected override Acls[] GetSeedData()
    {
      throw new NotImplementedException();
    }
  }
}
