namespace KozmikSystems.Migrations
{
    using KozmikSystems.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KozmikSystems.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KozmikSystems.Models.ApplicationDbContext context)
        {
            context.Navbars.AddOrUpdate(
              x => x.Id,
              new Navbar() { Id = 1, nameOption = "Dashboard", controller = "Home", action = "Index", imageClass = "fa fa-dashboard fa-fw", status = true, isParent = false, parentId = 0 },
              new Navbar() { Id = 2, nameOption = "Staff", imageClass = "fa fa-users fa-fw", status = true, isParent = true, parentId = 0 },
              new Navbar() { Id = 3, nameOption = "Add Staff Member", controller = "Users", action = "Create", status = true, isParent = false, parentId = 2 },
              new Navbar() { Id = 4, nameOption = "View All Staff Members", controller = "Users", action = "Index", status = true, isParent = false, parentId = 2 }
            );
        }
    }
}
