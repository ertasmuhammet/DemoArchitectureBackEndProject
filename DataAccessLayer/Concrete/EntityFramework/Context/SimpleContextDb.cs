using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Context
{
    public class SimpleContextDb: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KLSIU4N\\SQLEXPRESS;Database=DemoArchitectureDb;Integrated Security =true;");
        }

        public DbSet<User> USERS { get; set; }
        public DbSet<OperationClaim> OPERATION_CLAIMS { get; set; }
        public DbSet<UserOperationClaim> USER_OPERATION_CLAIMS { get; set; }
    }
}
