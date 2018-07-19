using System.Data.Entity.Migrations;

namespace FBFL.Model.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FBFL.Model.Database.FbflContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FBFL.Model.Database.FbflContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
