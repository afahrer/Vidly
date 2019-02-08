namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "dateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "dateAdded", c => c.DateTime(nullable: false));
        }
    }
}
