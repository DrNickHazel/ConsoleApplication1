using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Company c = new Company { Name = "Hazelcom" };

            c.Add(new Employee("Nick"));						// Constructs Employee with default Age value
            c.Add(new Employee { Name = "Tom" });
            c.Add(new Employee { Name = "Dick", Age = 20 });
            c.Add(new Employee { Name = "Harry", Age = 30 });
            c.Add(new Employee());

            for (int i = 0; i < c.Count; i++)
            {
                Console.WriteLine(c[i]);
            }

            Console.ReadLine();
        }
    }

    // Define other methods and classes here
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee()
        {
            Name = "Unknown";
            Age = -1;
        }
        public Employee(string name) : this() { Name = name; }
        public Employee(string name, int age = -1) : this(name) { Age = age; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Employee(Name: ");
            sb.Append(Name);
            sb.Append(", Age: ");
            sb.Append(Age);
            sb.Append(")");

            return sb.ToString();
        }
    }

    class Company
    {
        public string Name { get; set; }

        public Company() { Name = "Unknown"; }

        public Employee this[int index]
        {
            get { return employees[index]; }
        }

        public int Count { get { return employees.Count; } }

        public void Add(Employee e) { employees.Add(e); }

        private List<Employee> employees = new List<Employee>();
    }
}
