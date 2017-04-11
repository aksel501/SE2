namespace MUE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SPECIALTY");
            AlterColumn("dbo.SPECIALTY", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SPECIALTY", new[] { "ID", "NAME" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SPECIALTY");
            AlterColumn("dbo.SPECIALTY", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.SPECIALTY", new[] { "ID", "NAME" });
        }
    }
}
