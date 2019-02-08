namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateAddNotNull : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from Movies");
            AlterColumn("dbo.Movies", "dateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "dateAdded", c => c.DateTime());
        }
    }
}
