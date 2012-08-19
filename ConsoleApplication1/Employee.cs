using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
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
}
