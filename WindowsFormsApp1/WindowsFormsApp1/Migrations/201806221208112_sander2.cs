namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sander2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Arts", "Voornaam", c => c.String());
            AddColumn("dbo.Arts", "Achternaam", c => c.String());
            AddColumn("dbo.Klantens", "Verzekering_VerzekeringNaam", c => c.String(maxLength: 128));
            CreateIndex("dbo.Klantens", "ArtsID");
            CreateIndex("dbo.Klantens", "Verzekering_VerzekeringNaam");
            AddForeignKey("dbo.Klantens", "ArtsID", "dbo.Arts", "ArtsID", cascadeDelete: true);
            AddForeignKey("dbo.Klantens", "Verzekering_VerzekeringNaam", "dbo.Verzekerings", "VerzekeringNaam");
            DropColumn("dbo.Arts", "Naam");
            DropColumn("dbo.Arts", "Adres");
            DropColumn("dbo.Arts", "Postcode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Arts", "Postcode", c => c.String());
            AddColumn("dbo.Arts", "Adres", c => c.String());
            AddColumn("dbo.Arts", "Naam", c => c.String());
            DropForeignKey("dbo.Klantens", "Verzekering_VerzekeringNaam", "dbo.Verzekerings");
            DropForeignKey("dbo.Klantens", "ArtsID", "dbo.Arts");
            DropIndex("dbo.Klantens", new[] { "Verzekering_VerzekeringNaam" });
            DropIndex("dbo.Klantens", new[] { "ArtsID" });
            DropColumn("dbo.Klantens", "Verzekering_VerzekeringNaam");
            DropColumn("dbo.Arts", "Achternaam");
            DropColumn("dbo.Arts", "Voornaam");
        }
    }
}
