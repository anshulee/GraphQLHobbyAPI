namespace HobbyDataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hobbies",
                c => new
                    {
                        HobbyID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.HobbyID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.PersonHobbies",
                c => new
                    {
                        Person_PersonID = c.Int(nullable: false),
                        Hobby_HobbyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_PersonID, t.Hobby_HobbyID })
                .ForeignKey("dbo.People", t => t.Person_PersonID, cascadeDelete: true)
                .ForeignKey("dbo.Hobbies", t => t.Hobby_HobbyID, cascadeDelete: true)
                .Index(t => t.Person_PersonID)
                .Index(t => t.Hobby_HobbyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonHobbies", "Hobby_HobbyID", "dbo.Hobbies");
            DropForeignKey("dbo.PersonHobbies", "Person_PersonID", "dbo.People");
            DropIndex("dbo.PersonHobbies", new[] { "Hobby_HobbyID" });
            DropIndex("dbo.PersonHobbies", new[] { "Person_PersonID" });
            DropTable("dbo.PersonHobbies");
            DropTable("dbo.People");
            DropTable("dbo.Hobbies");
        }
    }
}
