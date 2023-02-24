namespace SoftStocksData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Credentials",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        StaffId = c.Int(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.Keyboards",
                c => new
                    {
                        ModelNumber = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ModelNumber);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        Role = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Salary = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContactNumber = c.String(),
                        PrimaryContact = c.String(),
                        BusinessAddress = c.String(),
                        NumberOfPurchases = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
            DropTable("dbo.Staffs");
            DropTable("dbo.Keyboards");
            DropTable("dbo.Credentials");
        }
    }
}
