namespace UserManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_M_Application",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tb_M_Contract",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        Employee_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Employee", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Tb_M_Employee",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Blood_Type = c.String(),
                        Gender = c.String(),
                        Phone_Number = c.String(),
                        Marital_Status = c.String(),
                        Address = c.String(),
                        Zip_Code = c.String(),
                        Email = c.String(),
                        Religion_Id = c.Int(nullable: false),
                        Position_Id = c.String(maxLength: 128),
                        Village_Id = c.Int(nullable: false),
                        Manager_Id = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Position", t => t.Position_Id)
                .ForeignKey("dbo.Tb_M_Religion", t => t.Religion_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tb_M_Village", t => t.Village_Id, cascadeDelete: true)
                .Index(t => t.Religion_Id)
                .Index(t => t.Position_Id)
                .Index(t => t.Village_Id);
            
            CreateTable(
                "dbo.Tb_M_Position",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        Department_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Department", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Tb_M_Department",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        Division_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Division", t => t.Division_Id)
                .Index(t => t.Division_Id);
            
            CreateTable(
                "dbo.Tb_M_Division",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tb_M_Religion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tb_M_Village",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        Subdistrict_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Subdistrict", t => t.Subdistrict_Id, cascadeDelete: true)
                .Index(t => t.Subdistrict_Id);
            
            CreateTable(
                "dbo.Tb_M_Subdistrict",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        District_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_District", t => t.District_Id, cascadeDelete: true)
                .Index(t => t.District_Id);
            
            CreateTable(
                "dbo.Tb_M_District",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        Province_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Province", t => t.Province_Id, cascadeDelete: true)
                .Index(t => t.Province_Id);
            
            CreateTable(
                "dbo.Tb_M_Province",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tb_T_Employee_Application",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Application_Id = c.String(maxLength: 128),
                        Employee_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Application", t => t.Application_Id)
                .ForeignKey("dbo.Tb_M_Employee", t => t.Employee_Id)
                .Index(t => t.Application_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Tb_T_Employee_Role",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Employee_Id = c.String(maxLength: 128),
                        Role_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Employee", t => t.Employee_Id)
                .ForeignKey("dbo.Tb_M_Role", t => t.Role_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Tb_M_Role",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tb_T_User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tb_T_Employee_Role", "Role_Id", "dbo.Tb_M_Role");
            DropForeignKey("dbo.Tb_T_Employee_Role", "Employee_Id", "dbo.Tb_M_Employee");
            DropForeignKey("dbo.Tb_T_Employee_Application", "Employee_Id", "dbo.Tb_M_Employee");
            DropForeignKey("dbo.Tb_T_Employee_Application", "Application_Id", "dbo.Tb_M_Application");
            DropForeignKey("dbo.Tb_M_Contract", "Employee_Id", "dbo.Tb_M_Employee");
            DropForeignKey("dbo.Tb_M_Employee", "Village_Id", "dbo.Tb_M_Village");
            DropForeignKey("dbo.Tb_M_Village", "Subdistrict_Id", "dbo.Tb_M_Subdistrict");
            DropForeignKey("dbo.Tb_M_Subdistrict", "District_Id", "dbo.Tb_M_District");
            DropForeignKey("dbo.Tb_M_District", "Province_Id", "dbo.Tb_M_Province");
            DropForeignKey("dbo.Tb_M_Employee", "Religion_Id", "dbo.Tb_M_Religion");
            DropForeignKey("dbo.Tb_M_Employee", "Position_Id", "dbo.Tb_M_Position");
            DropForeignKey("dbo.Tb_M_Position", "Department_Id", "dbo.Tb_M_Department");
            DropForeignKey("dbo.Tb_M_Department", "Division_Id", "dbo.Tb_M_Division");
            DropIndex("dbo.Tb_T_Employee_Role", new[] { "Role_Id" });
            DropIndex("dbo.Tb_T_Employee_Role", new[] { "Employee_Id" });
            DropIndex("dbo.Tb_T_Employee_Application", new[] { "Employee_Id" });
            DropIndex("dbo.Tb_T_Employee_Application", new[] { "Application_Id" });
            DropIndex("dbo.Tb_M_District", new[] { "Province_Id" });
            DropIndex("dbo.Tb_M_Subdistrict", new[] { "District_Id" });
            DropIndex("dbo.Tb_M_Village", new[] { "Subdistrict_Id" });
            DropIndex("dbo.Tb_M_Department", new[] { "Division_Id" });
            DropIndex("dbo.Tb_M_Position", new[] { "Department_Id" });
            DropIndex("dbo.Tb_M_Employee", new[] { "Village_Id" });
            DropIndex("dbo.Tb_M_Employee", new[] { "Position_Id" });
            DropIndex("dbo.Tb_M_Employee", new[] { "Religion_Id" });
            DropIndex("dbo.Tb_M_Contract", new[] { "Employee_Id" });
            DropTable("dbo.Tb_T_User");
            DropTable("dbo.Tb_M_Role");
            DropTable("dbo.Tb_T_Employee_Role");
            DropTable("dbo.Tb_T_Employee_Application");
            DropTable("dbo.Tb_M_Province");
            DropTable("dbo.Tb_M_District");
            DropTable("dbo.Tb_M_Subdistrict");
            DropTable("dbo.Tb_M_Village");
            DropTable("dbo.Tb_M_Religion");
            DropTable("dbo.Tb_M_Division");
            DropTable("dbo.Tb_M_Department");
            DropTable("dbo.Tb_M_Position");
            DropTable("dbo.Tb_M_Employee");
            DropTable("dbo.Tb_M_Contract");
            DropTable("dbo.Tb_M_Application");
        }
    }
}
