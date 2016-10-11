namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateYearlyToAnnual : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET membershipName = 'Annual' WHERE membershipname = 'Yearly'");
        }
        
        public override void Down()
        {
        }
    }
}
