using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Models
{
    public class Project : BaseModel
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

        private List<Organization> _organizations;

        public virtual List<Organization> Organizations
        {
            get { return _organizations; }
            set { _organizations = value; }
        }

        private List<UserStory> _userStories;

        public virtual List<UserStory> UserStories
        {
            get { return _userStories; }
            set { _userStories = value; }
        }

        private ProjectState _state;

        public ProjectState State
        {
            get { return _state; }
            set { _state = value; }
        }

    }
}
