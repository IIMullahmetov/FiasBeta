namespace FiasBeta.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnTypeTypeRemovedColumns : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AddressObjects", "UPDATEDATE");
            DropColumn("dbo.AddressObjects", "AOLEVEL");
            DropColumn("dbo.AddressObjects", "ACTSTATUS");
            DropColumn("dbo.AddressObjects", "CENTSTATUS");
            DropColumn("dbo.AddressObjects", "OPERSTATUS");
            DropColumn("dbo.AddressObjects", "CURRSTATUS");
            DropColumn("dbo.AddressObjects", "STARTDATE");
            DropColumn("dbo.AddressObjects", "ENDDATE");
            DropColumn("dbo.AddressObjects", "NORMDOC");
            DropColumn("dbo.AddressObjects", "LIVESTATUS");
            DropColumn("dbo.AddressObjects", "DIVTYPE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddressObjects", "DIVTYPE", c => c.Int(nullable: false));
            AddColumn("dbo.AddressObjects", "LIVESTATUS", c => c.Boolean(nullable: false));
            AddColumn("dbo.AddressObjects", "NORMDOC", c => c.String());
            AddColumn("dbo.AddressObjects", "ENDDATE", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.AddressObjects", "STARTDATE", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.AddressObjects", "CURRSTATUS", c => c.Int(nullable: false));
            AddColumn("dbo.AddressObjects", "OPERSTATUS", c => c.Int(nullable: false));
            AddColumn("dbo.AddressObjects", "CENTSTATUS", c => c.Int(nullable: false));
            AddColumn("dbo.AddressObjects", "ACTSTATUS", c => c.Int(nullable: false));
            AddColumn("dbo.AddressObjects", "AOLEVEL", c => c.Int(nullable: false));
            AddColumn("dbo.AddressObjects", "UPDATEDATE", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
