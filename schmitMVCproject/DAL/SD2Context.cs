using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using schmitMVCproject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace schmitMVCproject.DAL
{
    public class SD2Context : DbContext //inherits from DbContext
    {
        public SD2Context() : base("name = DefaultConnection")
        {
            //this method is a 'constructor' and is called when a new context is created
            //the base attribute says which connection string to use
            //SetInitializer statement
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SD2Context, schmitMVCproject.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        //include each object here. The value inside <> is the name of the class
        //the value outside should generally be the plural of the class name
        //and is the name used to reference the entity in code

        public DbSet<Employer> Employers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        */

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}