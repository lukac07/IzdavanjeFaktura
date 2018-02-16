namespace IzdavanjeFaktura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillID = c.Int(nullable: false, identity: true),
                        Bill_Number = c.Int(nullable: false),
                        Bill_Created_Date = c.DateTime(nullable: false),
                        Bill_Due_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bills");
        }
    }
}
