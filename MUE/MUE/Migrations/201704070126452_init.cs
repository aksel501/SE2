namespace MUE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {


            CreateTable(
                "dbo.Message",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    USERID = c.String(nullable: false, maxLength: 128),
                    DATETIMEMADE = c.DateTime(nullable: false),
                    TEXT = c.String(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.USERID)
                .Index(t => t.USERID);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.PROJECTTYPE", "PROJECTID", "dbo.PROJECT");
            DropForeignKey("dbo.PROJECTTYPE", "CATAGORYID", "dbo.CATAGORY");
            DropForeignKey("dbo.COLLABORATOR", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.COLLABORATOR", "ProjectId", "dbo.PROJECT");
            DropForeignKey("dbo.POST", "USERID", "dbo.AspNetUsers");
            DropForeignKey("dbo.POST", "POST1_ID", "dbo.POST");
            DropForeignKey("dbo.Message", "USERID", "dbo.AspNetUsers");
            DropForeignKey("dbo.EXPERT", "PARENTID", "dbo.AspNetUsers");
            DropForeignKey("dbo.SPECIALTY", "expertID", "dbo.EXPERT");
            DropForeignKey("dbo.CONVERSATION", "USERIDs", "dbo.AspNetUsers");
            DropForeignKey("dbo.CONVERSATION", "MessageIDs", "dbo.Message");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.PROJECTTYPE", new[] { "PROJECTID" });
            DropIndex("dbo.PROJECTTYPE", new[] { "CATAGORYID" });
            DropIndex("dbo.COLLABORATOR", new[] { "UserId" });
            DropIndex("dbo.COLLABORATOR", new[] { "ProjectId" });
            DropIndex("dbo.POST", new[] { "POST1_ID" });
            DropIndex("dbo.POST", new[] { "USERID" });
            DropIndex("dbo.SPECIALTY", new[] { "expertID" });
            DropIndex("dbo.EXPERT", new[] { "PARENTID" });
            DropIndex("dbo.Message", new[] { "USERID" });
            DropIndex("dbo.CONVERSATION", new[] { "MessageIDs" });
            DropIndex("dbo.CONVERSATION", new[] { "USERIDs" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.PROJECTTYPE");
            DropTable("dbo.COLLABORATOR");
            DropTable("dbo.CATAGORY");
            DropTable("dbo.PROJECT");
            DropTable("dbo.POST");
            DropTable("dbo.SPECIALTY");
            DropTable("dbo.EXPERT");
            DropTable("dbo.Message");
            DropTable("dbo.CONVERSATION");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
        }
    }
}
