using System.Collections.Generic;
using CompanyHierarchy.Departments;

namespace CompanyHierarchy.Person.Employee.RegularEmployee
{
    public class Developer : Employee,IDeveloper
    {
         private IList<Project> projects;

        public Developer(string firstName, string lastName, int id, double salary, Department department, IList<Project> projects)
            : base(firstName, lastName, id, salary, department)
        {
            this.projects = projects;
        }

        public Developer(string firstName, string lastName, int id, double salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
            this.projects = new List<Project>();
        }

        public void AddProject(Project project)
        {
            this.projects.Add(project);
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   string.Format("Projects:\n{0}", string.Join("\n", this.projects));
        }
    }
}