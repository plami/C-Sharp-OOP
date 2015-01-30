using CompanyHierarchy.Departments;

namespace CompanyHierarchy.Person.Employee
{
    public interface IEmployee
    {
        double Salary { get; set; }
        Department Department { get; set; }
    }
}