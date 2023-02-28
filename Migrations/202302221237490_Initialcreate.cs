namespace FilmsLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Sex = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        City = c.String(),
                        FinState = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Nation_Id)
                .Index(t => t.Nation_Id);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.DateTime(nullable: false),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BoxOffice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Viewers = c.Long(nullable: false),
                        Rating = c.Single(nullable: false),
                        CountryProduce_Id = c.Int(),
                        FilmProducer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryProduce_Id)
                .ForeignKey("dbo.Producers", t => t.FilmProducer_Id)
                .Index(t => t.CountryProduce_Id)
                .Index(t => t.FilmProducer_Id);
            
            CreateTable(
                "dbo.DemoCountries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Sex = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        City = c.String(),
                        FinState = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Nation_Id)
                .Index(t => t.Nation_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FilmActors",
                c => new
                    {
                        Film_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Film_Id, t.Actor_Id })
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_Id, cascadeDelete: true)
                .Index(t => t.Film_Id)
                .Index(t => t.Actor_Id);
            
            CreateTable(
                "dbo.DemoCountryFilms",
                c => new
                    {
                        DemoCountry_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DemoCountry_Id, t.Film_Id })
                .ForeignKey("dbo.DemoCountries", t => t.DemoCountry_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.DemoCountry_Id)
                .Index(t => t.Film_Id);
            
            CreateTable(
                "dbo.GenreFilms",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Film_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Film_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GenreFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.GenreFilms", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Producers", "Nation_Id", "dbo.Countries");
            DropForeignKey("dbo.Films", "FilmProducer_Id", "dbo.Producers");
            DropForeignKey("dbo.Films", "CountryProduce_Id", "dbo.Countries");
            DropForeignKey("dbo.Actors", "Nation_Id", "dbo.Countries");
            DropForeignKey("dbo.DemoCountryFilms", "Film_Id", "dbo.Films");
            DropForeignKey("dbo.DemoCountryFilms", "DemoCountry_Id", "dbo.DemoCountries");
            DropForeignKey("dbo.FilmActors", "Actor_Id", "dbo.Actors");
            DropForeignKey("dbo.FilmActors", "Film_Id", "dbo.Films");
            DropIndex("dbo.GenreFilms", new[] { "Film_Id" });
            DropIndex("dbo.GenreFilms", new[] { "Genre_Id" });
            DropIndex("dbo.DemoCountryFilms", new[] { "Film_Id" });
            DropIndex("dbo.DemoCountryFilms", new[] { "DemoCountry_Id" });
            DropIndex("dbo.FilmActors", new[] { "Actor_Id" });
            DropIndex("dbo.FilmActors", new[] { "Film_Id" });
            DropIndex("dbo.Producers", new[] { "Nation_Id" });
            DropIndex("dbo.Films", new[] { "FilmProducer_Id" });
            DropIndex("dbo.Films", new[] { "CountryProduce_Id" });
            DropIndex("dbo.Actors", new[] { "Nation_Id" });
            DropTable("dbo.GenreFilms");
            DropTable("dbo.DemoCountryFilms");
            DropTable("dbo.FilmActors");
            DropTable("dbo.Genres");
            DropTable("dbo.Producers");
            DropTable("dbo.Countries");
            DropTable("dbo.DemoCountries");
            DropTable("dbo.Films");
            DropTable("dbo.Actors");
        }
    }
}
