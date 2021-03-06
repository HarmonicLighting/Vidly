namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableToMoviesInDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Available", c => c.Int(nullable: false));
            Sql("UPDATE Movies Set Available = Stock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Available");
        }
    }
}
