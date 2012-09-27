using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Models
{    
    public enum ProjectState : int
    {
        Open = 1,
        InProgress = 2,
        Completed = 3,
        Cancelled = 4,
    }
}
