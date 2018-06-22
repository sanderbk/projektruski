namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arts",
                c => new
                    {
                        ArtsID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Adres = c.String(),
                        Postcode = c.String(),
                        Einddatum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ArtsID);
            
            CreateTable(
                "dbo.Klantens",
                c => new
                    {
                        KlantID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Adres = c.String(),
                        Plaats = c.String(),
                        ArtsID = c.Int(nullable: false),
                        VerzekeringsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KlantID);
            
            CreateTable(
                "dbo.Medicaties",
                c => new
                    {
                        MedicatieID = c.Int(nullable: false, identity: true),
                        MedicatieNaam = c.String(),
                        KlantID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicatieID)
                .ForeignKey("dbo.Klantens", t => t.KlantID, cascadeDelete: true)
                .Index(t => t.KlantID);
            
            CreateTable(
                "dbo.Verzekerings",
                c => new
                    {
                        VerzekeringNaam = c.String(nullable: false, maxLength: 128),
                        VerzekeringID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VerzekeringNaam);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicaties", "KlantID", "dbo.Klantens");
            DropIndex("dbo.Medicaties", new[] { "KlantID" });
            DropTable("dbo.Verzekerings");
            DropTable("dbo.Medicaties");
            DropTable("dbo.Klantens");
            DropTable("dbo.Arts");
        }
    }
}
