using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceAndAbstraction
{
    public class Discipline
    {
        private string name;
        private int numberOfLectures;
        private IList<Student> students = new List<Student>();

        public Discipline(string name, int numberOfLectures)
        {
            this.NumberOfLectures = numberOfLectures;
            this.Name = name;
        }

        public Discipline(string name, int numberOfLectures, IList<Student> students, string details = null)
            : this(name, numberOfLectures)
        {
            this.students = students;
            this.Details = details;
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name must not to be empty or null.");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("THe number of lecture must be integer number greater than zero.");
                }

                this.numberOfLectures = value;
            }
        }

        public string Details { get; set; }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            return "Discipline: " + this.Name + "\n  " +
                string.Join("  ", this.students.Select(s => s.ToString() + "\n").ToArray());
        }
    }
}