namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillMemberhipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly subscription' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly subscription' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly subscription' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
