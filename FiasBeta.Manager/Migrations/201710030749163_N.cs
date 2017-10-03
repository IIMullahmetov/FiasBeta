namespace FiasBeta.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class N : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AddressObjects", "TERRIFNSFL");
            DropColumn("dbo.AddressObjects", "IFNSUL");
            DropColumn("dbo.AddressObjects", "TERRIFNSUL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddressObjects", "TERRIFNSUL", c => c.String());
            AddColumn("dbo.AddressObjects", "IFNSUL", c => c.String());
            AddColumn("dbo.AddressObjects", "TERRIFNSFL", c => c.String());
        }
    }
}
