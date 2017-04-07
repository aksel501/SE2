namespace MUE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        disabled = c.Boolean(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CATAGORY",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        NAME = c.String(nullable: false, maxLength: 64),
                        DESCRIPTION = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PROJECT",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        COMPLETED = c.Boolean(nullable: false),
                        DATCOMPLETED = c.DateTime(storeType: "date"),
                        TITLE = c.String(nullable: false, maxLength: 40),
                        STARTDATE = c.DateTime(storeType: "date"),
                        DESCRIPTION = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SenderID = c.String(nullable: false, maxLength: 128),
                        RecieverID = c.String(nullable: false, maxLength: 128),
                        DATETIMEMADE = c.DateTime(nullable: false),
                        TEXT = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.RecieverID)
                .ForeignKey("dbo.AspNetUsers", t => t.SenderID)
                .Index(t => t.SenderID)
                .Index(t => t.RecieverID);
            
            CreateTable(
                "dbo.POST",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        REPLIED_TO_POST_ID = c.Int(),
                        USERID = c.String(nullable: false, maxLength: 128),
                        SUBJECT = c.String(nullable: false, maxLength: 20),
                        TITLE = c.String(nullable: false, maxLength: 20),
                        DATETIMEPOSTED = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.POST", t => t.REPLIED_TO_POST_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.USERID)
                .Index(t => t.REPLIED_TO_POST_ID)
                .Index(t => t.USERID);
            
            CreateTable(
                "dbo.SPECIALTY",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        NAME = c.String(nullable: false, maxLength: 64),
                        expertID = c.String(nullable: false, maxLength: 128),
                        DESCRIPTION = c.String(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID, t.NAME })
                .ForeignKey("dbo.AspNetUsers", t => t.expertID)
                .Index(t => t.expertID);
            
            CreateTable(
                "dbo.UserCatagories",
                c => new
                    {
                        CATAGORYID = c.Int(nullable: false),
                        USERID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CATAGORYID, t.USERID })
                .ForeignKey("dbo.CATAGORY", t => t.CATAGORYID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.USERID, cascadeDelete: true)
                .Index(t => t.CATAGORYID)
                .Index(t => t.USERID);
            
            CreateTable(
                "dbo.COLLABORATOR",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ProjectId, t.UserId })
                .ForeignKey("dbo.PROJECT", t => t.ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.PROJECTTYPE",
                c => new
                    {
                        CATAGORYID = c.Int(nullable: false),
                        PROJECTID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CATAGORYID, t.PROJECTID })
                .ForeignKey("dbo.CATAGORY", t => t.CATAGORYID, cascadeDelete: true)
                .ForeignKey("dbo.PROJECT", t => t.PROJECTID, cascadeDelete: true)
                .Index(t => t.CATAGORYID)
                .Index(t => t.PROJECTID);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.SPECIALTY", "expertID", "dbo.AspNetUsers");
            DropForeignKey("dbo.POST", "USERID", "dbo.AspNetUsers");
            DropForeignKey("dbo.POST", "REPLIED_TO_POST_ID", "dbo.POST");
            DropForeignKey("dbo.Message", "SenderID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Message", "RecieverID", "dbo.AspNetUsers");
            DropForeignKey("dbo.PROJECTTYPE", "PROJECTID", "dbo.PROJECT");
            DropForeignKey("dbo.PROJECTTYPE", "CATAGORYID", "dbo.CATAGORY");
            DropForeignKey("dbo.COLLABORATOR", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.COLLABORATOR", "ProjectId", "dbo.PROJECT");
            DropForeignKey("dbo.UserCatagories", "USERID", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserCatagories", "CATAGORYID", "dbo.CATAGORY");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.PROJECTTYPE", new[] { "PROJECTID" });
            DropIndex("dbo.PROJECTTYPE", new[] { "CATAGORYID" });
            DropIndex("dbo.COLLABORATOR", new[] { "UserId" });
            DropIndex("dbo.COLLABORATOR", new[] { "ProjectId" });
            DropIndex("dbo.UserCatagories", new[] { "USERID" });
            DropIndex("dbo.UserCatagories", new[] { "CATAGORYID" });
            DropIndex("dbo.SPECIALTY", new[] { "expertID" });
            DropIndex("dbo.POST", new[] { "USERID" });
            DropIndex("dbo.POST", new[] { "REPLIED_TO_POST_ID" });
            DropIndex("dbo.Message", new[] { "RecieverID" });
            DropIndex("dbo.Message", new[] { "SenderID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.PROJECTTYPE");
            DropTable("dbo.COLLABORATOR");
            DropTable("dbo.UserCatagories");
            DropTable("dbo.SPECIALTY");
            DropTable("dbo.POST");
            DropTable("dbo.Message");
            DropTable("dbo.PROJECT");
            DropTable("dbo.CATAGORY");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
        }
    }
}
