using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnlyDemo
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

        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<OrderInfo> OrderInfo { get; set; }

    }
}
