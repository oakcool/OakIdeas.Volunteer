using OakIdeas.Volunteer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Data
{
    public class VolunteerContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Models.Volunteer> Volunteers { get; set; }
        public DbSet<UserStory> UserStories { get; set; }
        
        public VolunteerContext()
            : base("Volunteer")
        {
        }
    }
}
