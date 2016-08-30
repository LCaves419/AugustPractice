namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            //use sql 
            Sql("INSERT INTO Genres (Id, Name) Values (1,'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) Values (2,'Blues')");
            Sql("INSERT INTO Genres (Id, Name) Values (3,'Rock')");
            Sql("INSERT INTO Genres (Id, Name) Values (4,'Country')");




        }

        public override void Down()
        {
            Sql("Delete From Genres Where Id in (1,2,3,4");


        }
    }
}
