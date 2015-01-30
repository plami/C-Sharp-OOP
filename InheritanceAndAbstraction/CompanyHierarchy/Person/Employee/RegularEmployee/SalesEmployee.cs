using System.Collections.Generic;
using CompanyHierarchy.Departments;

namespace CompanyHierarchy.Person.Employee.RegularEmployee
{
    public class SalesEmployee : Employee,ISalesEmployee
    {
        private IList<Product> sales;

        public SalesEmployee(string firstName, string lastName, int id, double salary, Department department,
            IList<Product> sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.sales = sales;
        }

        public SalesEmployee(string firstName, string lastName, int id, double salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
            this.sales = new List<Product>();
        }

        public void AddSales(Product product)
        {
            sales.Add(product);
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   string.Format("sales:\n{0}", string.Join("\n", sales));
        }
    }
}