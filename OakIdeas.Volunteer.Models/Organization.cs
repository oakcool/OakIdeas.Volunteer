using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Models
{
    public class Organization : BaseModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _website;

        public string WebSite
        {
            get { return _website; }
            set { _website = value; }
        }

        private List<Location> _locations;

        public virtual List<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        private List<Contact> _contacts;

        public virtual List<Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }        

        private List<Project> _projects;

        public virtual List<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }


        
    }
}
