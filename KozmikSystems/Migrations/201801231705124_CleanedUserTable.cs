namespace KozmikSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleanedUserTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.User", "FirstName");
            DropColumn("dbo.User", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "LastName", c => c.String());
            AddColumn("dbo.User", "FirstName", c => c.String());
        }
    }
}
