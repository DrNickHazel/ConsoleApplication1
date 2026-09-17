using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Company c = new Company { Name = "Hazelcom Ltd" };

            c.Add(new Employee("Nicholas"));						// Constructs Employee with default Age value
            c.Add(new Employee { Name = "Tom" });					// Constructs Employee with default Age value
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
}
