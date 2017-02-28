namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExThreeAddMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
