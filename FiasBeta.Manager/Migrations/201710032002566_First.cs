namespace FiasBeta.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressObjects",
                c => new
                    {
                        AOID = c.String(nullable: false, maxLength: 128),
                        AOGUID = c.String(),
                        FORMALNAME = c.String(),
                        REGIONCODE = c.String(),
                        AUTOCODE = c.String(),
                        AREACODE = c.String(),
                        CITYCODE = c.String(),
                        CTARCODE = c.String(),
                        PLACECODE = c.String(),
                        PLANCODE = c.String(),
                        STREETCODE = c.String(),
                        EXTRCODE = c.String(),
                        SEXTCODE = c.String(),
                        OFFNAME = c.String(),
                        POSTALCODE = c.String(),
                        OKATO = c.String(),
                        OKTMO = c.String(),
                        SHORTNAME = c.String(),
                        PARENTGUID = c.String(),
                        PREVID = c.String(),
                        NEXTID = c.String(),
                        CODE = c.String(),
                        PLAINCODE = c.String(),
                    })
                .PrimaryKey(t => t.AOID);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 32),
                        Subject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 32),
                        Type = c.String(maxLength: 16),
                        Subject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 32),
                        Type = c.String(maxLength: 16),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Case = c.String(maxLength: 2),
                        Street_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Streets", t => t.Street_Id)
                .Index(t => t.Street_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 3),
                        Name = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CityAreas",
                c => new
                    {
                        City_Id = c.Int(nullable: false),
                        Area_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.City_Id, t.Area_Id })
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: true)
                .ForeignKey("dbo.Areas", t => t.Area_Id, cascadeDelete: true)
                .Index(t => t.City_Id)
                .Index(t => t.Area_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Areas", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Houses", "Street_Id", "dbo.Streets");
            DropForeignKey("dbo.Streets", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.CityAreas", "Area_Id", "dbo.Areas");
            DropForeignKey("dbo.CityAreas", "City_Id", "dbo.Cities");
            DropIndex("dbo.CityAreas", new[] { "Area_Id" });
            DropIndex("dbo.CityAreas", new[] { "City_Id" });
            DropIndex("dbo.Houses", new[] { "Street_Id" });
            DropIndex("dbo.Streets", new[] { "City_Id" });
            DropIndex("dbo.Cities", new[] { "Subject_Id" });
            DropIndex("dbo.Areas", new[] { "Subject_Id" });
            DropTable("dbo.CityAreas");
            DropTable("dbo.Subjects");
            DropTable("dbo.Houses");
            DropTable("dbo.Streets");
            DropTable("dbo.Cities");
            DropTable("dbo.Areas");
            DropTable("dbo.AddressObjects");
        }
    }
}
