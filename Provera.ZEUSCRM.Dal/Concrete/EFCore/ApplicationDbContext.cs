using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Provera.ZEUSCRM.Core.Dal.EFCore;
using Provera.ZEUSCRM.Entity.Concrete;

namespace Provera.ZEUSCRM.Dal.Concrete.EFCore
{
    public class ApplicationDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        "Server = (localdb)\\MSSQLLocalDB; Database = ZEUSCRM; Trusted_Connection = True; MultipleActiveResultSets = true");
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }




        public DbSet<Account> Accounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
