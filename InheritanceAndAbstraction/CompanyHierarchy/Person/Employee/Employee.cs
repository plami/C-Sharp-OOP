using System;
using CompanyHierarchy.Departments;

namespace CompanyHierarchy.Person.Employee
{
    public class Employee : Person, IEmployee
    {
        private double salary;

        public Employee(string firstName, string lastName, int id, double salary, Department department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary
        {
            get { return this.salary; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The salary cannot be null or empty!");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   string.Format("salary: {0} BGN, department: {1}", this.Salary, this.Department);
        }
    }
}