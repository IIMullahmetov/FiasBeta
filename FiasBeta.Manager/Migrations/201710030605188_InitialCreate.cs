namespace FiasBeta.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        IFNSFL = c.String(),
                        TERRIFNSFL = c.String(),
                        IFNSUL = c.String(),
                        TERRIFNSUL = c.String(),
                        OKATO = c.String(),
                        OKTMO = c.String(),
                        UPDATEDATE = c.DateTimeOffset(nullable: false, precision: 7),
                        SHORTNAME = c.String(),
                        AOLEVEL = c.Int(nullable: false),
                        PARENTGUID = c.String(),
                        PREVID = c.String(),
                        NEXTID = c.String(),
                        CODE = c.String(),
                        PLAINCODE = c.String(),
                        ACTSTATUS = c.Int(nullable: false),
                        CENTSTATUS = c.Int(nullable: false),
                        OPERSTATUS = c.Int(nullable: false),
                        CURRSTATUS = c.Int(nullable: false),
                        STARTDATE = c.DateTimeOffset(nullable: false, precision: 7),
                        ENDDATE = c.DateTimeOffset(nullable: false, precision: 7),
                        NORMDOC = c.String(),
                        LIVESTATUS = c.Boolean(nullable: false),
                        DIVTYPE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AOID);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        HOUSEID = c.Int(nullable: false, identity: true),
                        POSTALCODE = c.String(),
                        REGIONCODE = c.String(),
                        IFNSFL = c.String(),
                        TERRIFNSFL = c.String(),
                        IFNSUL = c.String(),
                        TERRIFNSUL = c.String(),
                        OKATO = c.String(),
                        OKTMO = c.String(),
                        UPDATEDATE = c.DateTimeOffset(nullable: false, precision: 7),
                        HOUSENUM = c.String(),
                        ESTSTATUS = c.Int(nullable: false),
                        BUILDNUM = c.String(),
                        STRUCNUM = c.String(),
                        STRSTATUS = c.Int(nullable: false),
                        HOUSEGUID = c.String(),
                        AOGUID = c.String(),
                        STARTDATE = c.DateTimeOffset(nullable: false, precision: 7),
                        ENDDATE = c.DateTimeOffset(nullable: false, precision: 7),
                        STATSTATUS = c.Int(nullable: false),
                        NORMDOC = c.String(),
                        COUNTER = c.Int(nullable: false),
                        CADNUM = c.String(),
                        DIVTYPE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HOUSEID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Houses");
            DropTable("dbo.AddressObjects");
        }
    }
}
