namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '2001-10-10' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
