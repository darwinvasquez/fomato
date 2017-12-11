namespace disec.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            

            CreateTable(
                "USR_SIMOP.AspNetUsers",
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
                }
                )
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");



            CreateTable(
                "USR_SIMOP.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");          
          
            


            CreateTable(
              "USR_SIMOP.AspNetUserRoles",
              c => new
              {
                  UserId = c.String(nullable: false, maxLength: 128),
                  RoleId = c.String(nullable: false, maxLength: 128),
              })
              .PrimaryKey(t => new { t.UserId, t.RoleId })
              .ForeignKey("USR_SIMOP.AspNetRoles", t => t.RoleId, cascadeDelete: true)
              .ForeignKey("USR_SIMOP.AspNetUsers", t => t.UserId, cascadeDelete: true)
              .Index(t => t.UserId)
              .Index(t => t.RoleId);

            CreateTable(
                "USR_SIMOP.AspNetUserClaims",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("USR_SIMOP.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "USR_SIMOP.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("USR_SIMOP.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("USR_SIMOP.AspNetUserRoles", "UserId", "USR_SIMOP.AspNetUsers");
            DropForeignKey("USR_SIMOP.AspNetUserLogins", "UserId", "USR_SIMOP.AspNetUsers");
            DropForeignKey("USR_SIMOP.AspNetUserClaims", "UserId", "USR_SIMOP.AspNetUsers");
            DropForeignKey("USR_SIMOP.AspNetUserRoles", "RoleId", "USR_SIMOP.AspNetRoles");
            DropIndex("USR_SIMOP.AspNetUserLogins", new[] { "UserId" });
            DropIndex("USR_SIMOP.AspNetUserClaims", new[] { "UserId" });
            DropIndex("USR_SIMOP.AspNetUsers", "UserNameIndex");
            DropIndex("USR_SIMOP.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("USR_SIMOP.AspNetUserRoles", new[] { "UserId" });
            DropIndex("USR_SIMOP.AspNetRoles", "RoleNameIndex");
            DropTable("USR_SIMOP.AspNetUserLogins");
            DropTable("USR_SIMOP.AspNetUserClaims");
            DropTable("USR_SIMOP.AspNetUsers");
            DropTable("USR_SIMOP.AspNetUserRoles");
            DropTable("USR_SIMOP.AspNetRoles");
        }
    }
}
