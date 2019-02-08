namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieDetials : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "releaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "dateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "stock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "stock");
            DropColumn("dbo.Movies", "dateAdded");
            DropColumn("dbo.Movies", "releaseDate");
        }
    }
}
