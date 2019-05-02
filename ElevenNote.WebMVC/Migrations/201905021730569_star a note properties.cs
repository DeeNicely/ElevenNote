namespace ElevenNote.WebMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class staranoteproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "IsStarred", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "IsStarred");
        }
    }
}
