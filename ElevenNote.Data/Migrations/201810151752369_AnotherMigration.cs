namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnotherMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Note", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "CreatedUtc");
            DropColumn("dbo.Note", "OwnerId");
        }
    }
}
