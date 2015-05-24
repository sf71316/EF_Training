using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Trainnig
{
    public partial class ContosoUniversityEntities : DbContext
    {
        public override int SaveChanges()
        {
            foreach (var item in this.ChangeTracker.Entries())
            {
                if (item.State == EntityState.Modified)
                {
                    item.CurrentValues.SetValues(new { ModifiedOn = DateTime.Now });
                }
                if (item.State == EntityState.Added)
                {
                    item.CurrentValues.SetValues(new { CreatedOn = DateTime.Now });
                    item.CurrentValues.SetValues(new { ModifiedOn = DateTime.Now });
                }
            }
            return base.SaveChanges();
        }
    }
}
