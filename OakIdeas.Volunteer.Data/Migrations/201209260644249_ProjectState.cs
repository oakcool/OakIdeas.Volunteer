namespace OakIdeas.Volunteer.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectState : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        WebSite = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        StreetNumber = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        AdminDistrict = c.String(),
                        AdminDistrict2 = c.String(),
                        CountryRegion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserStories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LocationOrganizations",
                c => new
                    {
                        Location_Id = c.Int(nullable: false),
                        Organization_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Location_Id, t.Organization_Id })
                .ForeignKey("dbo.Locations", t => t.Location_Id, cascadeDelete: true)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id, cascadeDelete: true)
                .Index(t => t.Location_Id)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.ContactOrganizations",
                c => new
                    {
                        Contact_Id = c.Int(nullable: false),
                        Organization_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contact_Id, t.Organization_Id })
                .ForeignKey("dbo.Contacts", t => t.Contact_Id, cascadeDelete: true)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id, cascadeDelete: true)
                .Index(t => t.Contact_Id)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.OrganizationProjects",
                c => new
                    {
                        Organization_Id = c.Int(nullable: false),
                        Project_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Organization_Id, t.Project_Id })
                .ForeignKey("dbo.Organizations", t => t.Organization_Id, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.Project_Id, cascadeDelete: true)
                .Index(t => t.Organization_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.VolunteerUserStories",
                c => new
                    {
                        Volunteer_Id = c.Int(nullable: false),
                        UserStory_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Volunteer_Id, t.UserStory_Id })
                .ForeignKey("dbo.Volunteers", t => t.Volunteer_Id, cascadeDelete: true)
                .ForeignKey("dbo.UserStories", t => t.UserStory_Id, cascadeDelete: true)
                .Index(t => t.Volunteer_Id)
                .Index(t => t.UserStory_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.VolunteerUserStories", new[] { "UserStory_Id" });
            DropIndex("dbo.VolunteerUserStories", new[] { "Volunteer_Id" });
            DropIndex("dbo.OrganizationProjects", new[] { "Project_Id" });
            DropIndex("dbo.OrganizationProjects", new[] { "Organization_Id" });
            DropIndex("dbo.ContactOrganizations", new[] { "Organization_Id" });
            DropIndex("dbo.ContactOrganizations", new[] { "Contact_Id" });
            DropIndex("dbo.LocationOrganizations", new[] { "Organization_Id" });
            DropIndex("dbo.LocationOrganizations", new[] { "Location_Id" });
            DropIndex("dbo.UserStories", new[] { "Project_Id" });
            DropForeignKey("dbo.VolunteerUserStories", "UserStory_Id", "dbo.UserStories");
            DropForeignKey("dbo.VolunteerUserStories", "Volunteer_Id", "dbo.Volunteers");
            DropForeignKey("dbo.OrganizationProjects", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.OrganizationProjects", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.ContactOrganizations", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.ContactOrganizations", "Contact_Id", "dbo.Contacts");
            DropForeignKey("dbo.LocationOrganizations", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.LocationOrganizations", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.UserStories", "Project_Id", "dbo.Projects");
            DropTable("dbo.VolunteerUserStories");
            DropTable("dbo.OrganizationProjects");
            DropTable("dbo.ContactOrganizations");
            DropTable("dbo.LocationOrganizations");
            DropTable("dbo.Volunteers");
            DropTable("dbo.UserStories");
            DropTable("dbo.Contacts");
            DropTable("dbo.Locations");
            DropTable("dbo.Organizations");
            DropTable("dbo.Projects");
        }
    }
}
