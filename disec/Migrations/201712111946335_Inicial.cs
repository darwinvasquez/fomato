namespace disec.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "USR_FORMATOS.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "USR_FORMATOS.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("USR_FORMATOS.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("USR_FORMATOS.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "USR_FORMATOS.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Decimal(nullable: false, precision: 1, scale: 0),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Decimal(nullable: false, precision: 1, scale: 0),
                        TwoFactorEnabled = c.Decimal(nullable: false, precision: 1, scale: 0),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Decimal(nullable: false, precision: 1, scale: 0),
                        AccessFailedCount = c.Decimal(nullable: false, precision: 10, scale: 0),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "USR_FORMATOS.AspNetUserClaims",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("USR_FORMATOS.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "USR_FORMATOS.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("USR_FORMATOS.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("USR_FORMATOS.AspNetUserRoles", "UserId", "USR_FORMATOS.AspNetUsers");
            DropForeignKey("USR_FORMATOS.AspNetUserLogins", "UserId", "USR_FORMATOS.AspNetUsers");
            DropForeignKey("USR_FORMATOS.AspNetUserClaims", "UserId", "USR_FORMATOS.AspNetUsers");
            DropForeignKey("USR_FORMATOS.AspNetUserRoles", "RoleId", "USR_FORMATOS.AspNetRoles");
            DropIndex("USR_FORMATOS.AspNetUserLogins", new[] { "UserId" });
            DropIndex("USR_FORMATOS.AspNetUserClaims", new[] { "UserId" });
            DropIndex("USR_FORMATOS.AspNetUsers", "UserNameIndex");
            DropIndex("USR_FORMATOS.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("USR_FORMATOS.AspNetUserRoles", new[] { "UserId" });
            DropIndex("USR_FORMATOS.AspNetRoles", "RoleNameIndex");
            DropTable("USR_FORMATOS.AspNetUserLogins");
            DropTable("USR_FORMATOS.AspNetUserClaims");
            DropTable("USR_FORMATOS.AspNetUsers");
            DropTable("USR_FORMATOS.AspNetUserRoles");
            DropTable("USR_FORMATOS.AspNetRoles");
        }
    }
}
