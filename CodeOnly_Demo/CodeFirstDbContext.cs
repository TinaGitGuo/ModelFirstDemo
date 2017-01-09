using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnly_Demo
{
    public class CodeFirstDbContext : DbContext
    {

        public CodeFirstDbContext()
            : base("name=DataModelContainer")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public DbSet<BookMaster> UserInfo { get; set; }
        public DbSet<Publisher> OrderInfo { get; set; }

    }
}
