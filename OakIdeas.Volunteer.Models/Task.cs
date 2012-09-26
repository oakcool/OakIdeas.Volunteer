using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Models
{
    public class Task : BaseModel
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

        private Project _project;

        public Project Project
        {
            get { return _project; }
            set { _project = value; }
        }        

        private List<Volunteer> _volunteers;

        public List<Volunteer> Volunteers
        {
            get { return _volunteers; }
            set { _volunteers = value; }
        }
        
    }
}
