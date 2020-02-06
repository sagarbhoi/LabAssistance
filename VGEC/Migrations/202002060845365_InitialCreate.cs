namespace VGEC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Fac_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        ContactNo = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Fac_Id);
            
            CreateTable(
                "dbo.Mentors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        C_Id = c.Int(nullable: false),
                        F_Id = c.Int(nullable: false),
                        Sem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        E_Id = c.String(nullable: false),
                        Name = c.String(),
                        Password = c.String(nullable: false),
                        Email = c.String(),
                        Contact = c.String(),
                        C_Id = c.Int(nullable: false),
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
        }
    }
}
