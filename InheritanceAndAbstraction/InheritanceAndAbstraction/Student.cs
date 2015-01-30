using System;

namespace InheritanceAndAbstraction
{
    public class Student : People
    {
        private int classNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber 
        {
            get { return this.classNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The class number cannot be negative or zero!");
                }
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", class number: " + this.classNumber;
        }
    }
}