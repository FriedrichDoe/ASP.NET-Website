namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExThreeAddMovieData1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, StockCount, GenreId) Values ('John Wick','2012-06-18', '2016-10-11', 3, 6 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, StockCount, GenreId) Values ('Titanic','1998-09-10', '2015-10-11', 2, 4 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, StockCount, GenreId) Values ('Baymax','2012-07-08', '2015-01-01', 7, 3 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, StockCount, GenreId) Values ('Findet Dori','2014-07-08', '2016-03-21', 4, 3 )");
            Sql("INSERT INTO Movies (Name, ReleaseDate, AddedDate, StockCount, GenreId) Values ('Conjuring','2012-06-18', '2016-10-11', 3, 2 )");
        }
        
        public override void Down()
        {
        }
    }
}
