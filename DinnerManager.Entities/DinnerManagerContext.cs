using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerManager.Entities
{
    public class DinnerManagerContext : DbContext
    {
        public DinnerManagerContext(string connectionString) : base(connectionString)
        {
            this.Database.CreateIfNotExists();
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Meal> Meals { get; set; }
    }
}
