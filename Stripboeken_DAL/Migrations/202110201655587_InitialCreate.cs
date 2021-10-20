namespace Stripboeken_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Reeksnummer = c.Int(nullable: false),
                        Titel = c.String(nullable: false),
                        Beschrijving = c.String(),
                        AlbumtypeID = c.Int(nullable: false),
                        Favoriet = c.Boolean(nullable: false),
                        Waardering = c.Byte(),
                        Uitgiftedatum = c.DateTime(nullable: false),
                        EersteDruk = c.Boolean(nullable: false),
                        Kaft = c.String(nullable: false),
                        Inkleuring = c.String(nullable: false),
                        Paginas = c.Int(nullable: false),
                        Breedte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hoogte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Taal = c.String(nullable: false),
                        Conditie = c.Byte(),
                        Inbedrag = c.Decimal(storeType: "money"),
                        Waarde = c.Decimal(storeType: "money"),
                        Uitbedrag = c.Decimal(storeType: "money"),
                        LaatsteUpdate = c.DateTime(nullable: false),
                        ReeksID = c.Int(nullable: false),
                        UitgeverID = c.Int(nullable: false),
                        EventIDIn = c.Int(),
                        EventIDUit = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Reeksen", t => t.ReeksID, cascadeDelete: true)
                .Index(t => t.ReeksID);
            
            CreateTable(
                "dbo.Reeksen",
                c => new
                    {
                        ReeksID = c.Int(nullable: false, identity: true),
                        Titel = c.String(nullable: false),
                        Beschrijving = c.String(nullable: false),
                        ReekstypeID = c.Int(nullable: false),
                        Website = c.String(nullable: false),
                        LaatsteUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReeksID)
                .ForeignKey("dbo.Reekstypes", t => t.ReekstypeID, cascadeDelete: true)
                .Index(t => t.ReekstypeID);
            
            CreateTable(
                "dbo.ReeksenGenres",
                c => new
                    {
                        ReeksGenreID = c.Int(nullable: false, identity: true),
                        ReeksID = c.Int(nullable: false),
                        GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReeksGenreID)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Reeksen", t => t.ReeksID, cascadeDelete: true)
                .Index(t => t.ReeksID)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Naam = c.String(nullable: false),
                        Beschrijving = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Reekstypes",
                c => new
                    {
                        ReekstypeID = c.Int(nullable: false, identity: true),
                        Beschrijving = c.String(),
                    })
                .PrimaryKey(t => t.ReekstypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reeksen", "ReekstypeID", "dbo.Reekstypes");
            DropForeignKey("dbo.ReeksenGenres", "ReeksID", "dbo.Reeksen");
            DropForeignKey("dbo.ReeksenGenres", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Albums", "ReeksID", "dbo.Reeksen");
            DropIndex("dbo.ReeksenGenres", new[] { "GenreID" });
            DropIndex("dbo.ReeksenGenres", new[] { "ReeksID" });
            DropIndex("dbo.Reeksen", new[] { "ReekstypeID" });
            DropIndex("dbo.Albums", new[] { "ReeksID" });
            DropTable("dbo.Reekstypes");
            DropTable("dbo.Genres");
            DropTable("dbo.ReeksenGenres");
            DropTable("dbo.Reeksen");
            DropTable("dbo.Albums");
        }
    }
}
