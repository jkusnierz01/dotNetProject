using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Database
{
    public class NewsAppDBContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
