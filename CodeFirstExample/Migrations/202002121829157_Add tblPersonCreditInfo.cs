namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblPersonCreditInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPersonCreditInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CreditCardNumber = c.String(),
                        Percent = c.Double(nullable: false),
                        Balance = c.Double(nullable: false),
                        Sum = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblPersons", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblPersonCreditInfoes", "Id", "dbo.tblPersons");
            DropIndex("dbo.tblPersonCreditInfoes", new[] { "Id" });
            DropTable("dbo.tblPersonCreditInfoes");
        }
    }
}
