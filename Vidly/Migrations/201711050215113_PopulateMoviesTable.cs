namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (1,'Something To Think', 2, CAST('March 10 2010 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (2,'I Do', 1, CAST('March 12 2010 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (3,'Feeling Down', 3, CAST('January 19 2010 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (4,'Falling People', 4, CAST('April 20 2010 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (5,'Hanamura', 5, CAST('June 5 2000 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (6,'Relinquished', 6, CAST('August 1 2002 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (7,'Tamer of Fate', 2, CAST('October 12 2012 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded) Values (8,'I Am You', 4, CAST('December 8 2015 00:00AM' as DATETIME), CAST('May 10 2017 00:00AM' as DATETIME))");
        }
        
        public override void Down()
        {
        }
    }
}
