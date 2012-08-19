using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
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
