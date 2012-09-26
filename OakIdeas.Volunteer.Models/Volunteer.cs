using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Models
{
    public class Volunteer : BaseModel
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private List<Project> _projects;

        public virtual List<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }


        
    }
}
