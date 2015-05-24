using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_CodeFirst
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=Ef_CodeFirst.Properties.Settings.DbConnection")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }

}
