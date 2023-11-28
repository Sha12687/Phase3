namespace AddMarkApiMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AddMarkApiMVC.Data.AddMarkApiMVCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AddMarkApiMVC.Data.AddMarkApiMVCContext";
        }

        protected override void Seed(AddMarkApiMVC.Data.AddMarkApiMVCContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
