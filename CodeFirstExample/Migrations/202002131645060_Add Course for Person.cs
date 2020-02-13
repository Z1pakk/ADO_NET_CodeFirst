namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseforPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPersonCourses",
                c => new
                    {
                        IdPerson = c.Int(nullable: false),
                        IdCourse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdPerson, t.IdCourse })
                .ForeignKey("dbo.tblCourses", t => t.IdCourse, cascadeDelete: true)
                .ForeignKey("dbo.tblPersons", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdPerson)
                .Index(t => t.IdCourse);
            
            CreateTable(
                "dbo.tblCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DurationInCredits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblPersonCourses", "IdPerson", "dbo.tblPersons");
            DropForeignKey("dbo.tblPersonCourses", "IdCourse", "dbo.tblCourses");
            DropIndex("dbo.tblPersonCourses", new[] { "IdCourse" });
            DropIndex("dbo.tblPersonCourses", new[] { "IdPerson" });
            DropTable("dbo.tblCourses");
            DropTable("dbo.tblPersonCourses");
        }
    }
}
