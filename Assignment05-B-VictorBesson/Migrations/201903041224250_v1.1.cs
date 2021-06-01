namespace Assignment05_B_VictorBesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo._IT_Specialty", "Specialty", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo._IT_Member", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo._IT_Member", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo._IT_Member", "Country", c => c.String(nullable: false, maxLength: 35));
            AlterColumn("dbo._IT_Member", "City", c => c.String(nullable: false, maxLength: 35));
            AlterColumn("dbo._IT_Member", "Email", c => c.String(nullable: false, maxLength: 62));
            AlterColumn("dbo._IT_Member", "Password", c => c.String(nullable: false));
            AlterColumn("dbo._Request", "RequestDescription", c => c.String(nullable: false));
            AlterColumn("dbo._Priority", "Description", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo._RequestStatus", "RequestStatus", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo._RequestType", "RequestType", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo._User", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo._User", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo._User", "Country", c => c.String(nullable: false, maxLength: 35));
            AlterColumn("dbo._User", "City", c => c.String(nullable: false, maxLength: 35));
            AlterColumn("dbo._User", "Email", c => c.String(nullable: false, maxLength: 62));
            AlterColumn("dbo._User", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo._User", "Password", c => c.String());
            AlterColumn("dbo._User", "Email", c => c.String(maxLength: 62));
            AlterColumn("dbo._User", "City", c => c.String(maxLength: 35));
            AlterColumn("dbo._User", "Country", c => c.String(maxLength: 35));
            AlterColumn("dbo._User", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo._User", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo._RequestType", "RequestType", c => c.String(maxLength: 25));
            AlterColumn("dbo._RequestStatus", "RequestStatus", c => c.String(maxLength: 20));
            AlterColumn("dbo._Priority", "Description", c => c.String(maxLength: 20));
            AlterColumn("dbo._Request", "RequestDescription", c => c.String());
            AlterColumn("dbo._IT_Member", "Password", c => c.String());
            AlterColumn("dbo._IT_Member", "Email", c => c.String(maxLength: 62));
            AlterColumn("dbo._IT_Member", "City", c => c.String(maxLength: 35));
            AlterColumn("dbo._IT_Member", "Country", c => c.String(maxLength: 35));
            AlterColumn("dbo._IT_Member", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo._IT_Member", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo._IT_Specialty", "Specialty", c => c.String(maxLength: 25));
        }
    }
}
