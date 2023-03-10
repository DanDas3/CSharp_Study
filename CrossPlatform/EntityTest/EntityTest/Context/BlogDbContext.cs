using EntityTest.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Context
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}
