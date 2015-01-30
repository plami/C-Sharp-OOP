using System.Collections.Generic;
using System.Linq;

namespace InheritanceAndAbstraction
{
    public class Teacher : People
    {
        private IList<Discipline> disciplines = new List<Discipline>();

        public Teacher(string name)
            : base(name)
        {
        }

        public Teacher(string name, IList<Discipline> disciplines)
            : base(name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            return base.ToString() + "\n " + string.Join("\n ",this.disciplines.Select(d => d.ToString()).ToArray());
        }
    }

    public class CopyOfTeacher : People
    {
        private IList<Discipline> disciplines = new List<Discipline>();

        public CopyOfTeacher(string name)
            : base(name)
        {
        }

        public CopyOfTeacher(string name, IList<Discipline> disciplines)
            : base(name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public override string ToString()
        {
            return base.ToString() + "\n " + string.Join("\n ", this.disciplines.Select(d => d.ToString()).ToArray());
        }
    }
}