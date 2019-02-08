namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixBirthProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime());
            DropColumn("dbo.Customers", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MyProperty", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
