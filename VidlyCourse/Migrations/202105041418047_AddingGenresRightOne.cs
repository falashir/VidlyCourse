namespace VidlyCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenresRightOne : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Si-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Animation')");
        }

        public override void Down()
        {
        }
    }
}
