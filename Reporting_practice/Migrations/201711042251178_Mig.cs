namespace Reporting_practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Employee_id = c.Int(nullable: false, identity: true),
                        Employee_name = c.String(),
                        Employee_Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Employee_Date_of_Join = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Employee_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
