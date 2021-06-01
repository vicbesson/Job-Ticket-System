namespace Assignment05_B_VictorBesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo._IT_Specialty",
                c => new
                    {
                        SpecialtyID = c.Int(nullable: false, identity: true),
                        Specialty = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.SpecialtyID);
            
            CreateTable(
                "dbo._IT_Member",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        SpecialtyID = c.Int(nullable: false),
                        Country = c.String(maxLength: 35),
                        City = c.String(maxLength: 35),
                        Email = c.String(maxLength: 62),
                        Password = c.String(),
                        HiredDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo._IT_Specialty", t => t.SpecialtyID)
                .Index(t => t.SpecialtyID);
            
            CreateTable(
                "dbo._Request",
                c => new
                    {
                        RequestID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        RequestTypeID = c.Int(nullable: false),
                        RequestDescription = c.String(),
                        RequestCreated = c.DateTime(nullable: false),
                        RequestAccepted = c.DateTime(),
                        RequestCompleted = c.DateTime(),
                        PriorityID = c.Int(),
                        StaffID = c.Int(),
                        RequestStatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RequestID)
                .ForeignKey("dbo._IT_Member", t => t.StaffID)
                .ForeignKey("dbo._Priority", t => t.PriorityID)
                .ForeignKey("dbo._RequestStatus", t => t.RequestStatusID)
                .ForeignKey("dbo._RequestType", t => t.RequestTypeID)
                .ForeignKey("dbo._User", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.RequestTypeID)
                .Index(t => t.PriorityID)
                .Index(t => t.StaffID)
                .Index(t => t.RequestStatusID);
            
            CreateTable(
                "dbo._Priority",
                c => new
                    {
                        PriorityID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.PriorityID);
            
            CreateTable(
                "dbo._RequestStatus",
                c => new
                    {
                        RequestStatusID = c.Int(nullable: false, identity: true),
                        RequestStatus = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.RequestStatusID);
            
            CreateTable(
                "dbo._RequestType",
                c => new
                    {
                        RequestTypeID = c.Int(nullable: false, identity: true),
                        RequestType = c.String(maxLength: 25),
                        SpecialtyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RequestTypeID)
                .ForeignKey("dbo._IT_Specialty", t => t.SpecialtyID)
                .Index(t => t.SpecialtyID);
            
            CreateTable(
                "dbo._User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Country = c.String(maxLength: 35),
                        City = c.String(maxLength: 35),
                        Email = c.String(maxLength: 62),
                        Password = c.String(),
                        JoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo._Request", "UserID", "dbo._User");
            DropForeignKey("dbo._Request", "RequestTypeID", "dbo._RequestType");
            DropForeignKey("dbo._RequestType", "SpecialtyID", "dbo._IT_Specialty");
            DropForeignKey("dbo._Request", "RequestStatusID", "dbo._RequestStatus");
            DropForeignKey("dbo._Request", "PriorityID", "dbo._Priority");
            DropForeignKey("dbo._Request", "StaffID", "dbo._IT_Member");
            DropForeignKey("dbo._IT_Member", "SpecialtyID", "dbo._IT_Specialty");
            DropIndex("dbo._RequestType", new[] { "SpecialtyID" });
            DropIndex("dbo._Request", new[] { "RequestStatusID" });
            DropIndex("dbo._Request", new[] { "StaffID" });
            DropIndex("dbo._Request", new[] { "PriorityID" });
            DropIndex("dbo._Request", new[] { "RequestTypeID" });
            DropIndex("dbo._Request", new[] { "UserID" });
            DropIndex("dbo._IT_Member", new[] { "SpecialtyID" });
            DropTable("dbo._User");
            DropTable("dbo._RequestType");
            DropTable("dbo._RequestStatus");
            DropTable("dbo._Priority");
            DropTable("dbo._Request");
            DropTable("dbo._IT_Member");
            DropTable("dbo._IT_Specialty");
        }
    }
}
