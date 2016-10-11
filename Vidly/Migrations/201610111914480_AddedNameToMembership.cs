namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameToMembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "membershipName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "membershipName");
        }
    }
}
