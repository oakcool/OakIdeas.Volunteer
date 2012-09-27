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

        private List<UserStory> _userStories;

        public virtual List<UserStory> UserStories
        {
            get { return _userStories; }
            set { _userStories = value; }
        }
    }
}
