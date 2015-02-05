using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Hierarchy
{
    class Project
    {
        public Project(string projectName, DateTime projectStartDate, string details,
            ProjectState projectState = ProjectState.Open)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.ProjectState = projectState;
        }

        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public ProjectState ProjectState { get; set; }
        public string Details { get; set; }

        public void CloseProject()
        {
            if (ProjectState == ProjectState.Open)
            {
                ProjectState = ProjectState.Closed;
            }
        }

    }
}
