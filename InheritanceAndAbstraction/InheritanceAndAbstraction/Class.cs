using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceAndAbstraction
{
    public class Class
    {
        private string textIdentifier;
        private IList<Teacher> teachers = new List<Teacher>();

        public Class(string textIdentifier)
        {
            this.textIdentifier = textIdentifier;
        }

        public Class(string textIdentifier, IList<Teacher> teachers, string details = null)
            : this(textIdentifier)
        {
            this.teachers = teachers;
            this.Details = details;
        }

        public string Details { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            return "Class " + this.textIdentifier + "\n" +
                   string.Join("\n", this.teachers.Select(t => t.ToString()).ToArray());
        }
    }
}