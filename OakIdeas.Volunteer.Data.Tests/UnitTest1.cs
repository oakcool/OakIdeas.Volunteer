using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OakIdeas.Volunteer.Models;

namespace OakIdeas.Volunteer.Data.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_a_project()
        {
            using (VolunteerContext context = new VolunteerContext())
            {
                Project project = new Project();
                project.Name = "test";
                project.Description = " some decription ";
                project.State = ProjectState.Open;

                context.Projects.Add(project);

                context.SaveChanges();
            }
        }
    }
}
