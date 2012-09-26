using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Models
{
    public class Contact : BaseModel
    {      

        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private List<Organization> _organizations;

        public virtual List<Organization> Organizations
        {
            get { return _organizations; }
            set { _organizations = value; }
        }
        
    }
}
