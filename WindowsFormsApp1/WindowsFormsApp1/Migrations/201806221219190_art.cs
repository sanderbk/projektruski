namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class art : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Klantens", "ArtsID", "dbo.Arts");
            DropIndex("dbo.Klantens", new[] { "ArtsID" });
            RenameColumn(table: "dbo.Klantens", name: "ArtsID", newName: "Arts_ArtsID");
            AlterColumn("dbo.Klantens", "Arts_ArtsID", c => c.Int());
            CreateIndex("dbo.Klantens", "Arts_ArtsID");
            AddForeignKey("dbo.Klantens", "Arts_ArtsID", "dbo.Arts", "ArtsID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Klantens", "Arts_ArtsID", "dbo.Arts");
            DropIndex("dbo.Klantens", new[] { "Arts_ArtsID" });
            AlterColumn("dbo.Klantens", "Arts_ArtsID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Klantens", name: "Arts_ArtsID", newName: "ArtsID");
            CreateIndex("dbo.Klantens", "ArtsID");
            AddForeignKey("dbo.Klantens", "ArtsID", "dbo.Arts", "ArtsID", cascadeDelete: true);
        }
    }
}
