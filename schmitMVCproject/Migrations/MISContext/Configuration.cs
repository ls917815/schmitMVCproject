namespace schmitMVCproject.Migrations.MISContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<schmitMVCproject.DAL.SD2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations/MISContext";
            ContextKey = "schmitMVCproject.DAL.MISContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(schmitMVCproject.DAL.SD2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
