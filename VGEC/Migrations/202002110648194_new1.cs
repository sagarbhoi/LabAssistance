namespace VGEC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Fac_Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        ContactNo = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Fac_Id);
            
            CreateTable(
                "dbo.Mentors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        C_Id = c.Int(nullable: false),
                        Fac_Id = c.Int(nullable: false),
                        Sem = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        E_Id = c.String(nullable: false),
                        Email = c.String(),
                        Contact = c.String(),
                        C_Id = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Semester = c.Int(nullable: false),
                        Subject_Name = c.String(nullable: false),
                        Sub_Code = c.Int(nullable: false),
                        IsElective = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.Mentors");
            DropTable("dbo.Faculties");
            DropTable("dbo.Admins");
        }
    }
}
