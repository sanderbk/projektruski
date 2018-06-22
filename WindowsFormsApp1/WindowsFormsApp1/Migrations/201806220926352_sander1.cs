namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sander1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klantens", "Voornaam", c => c.String());
            AddColumn("dbo.Klantens", "Achternaam", c => c.String());
            DropColumn("dbo.Klantens", "Naam");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "Naam", c => c.String());
            DropColumn("dbo.Klantens", "Achternaam");
            DropColumn("dbo.Klantens", "Voornaam");
        }
    }
}
