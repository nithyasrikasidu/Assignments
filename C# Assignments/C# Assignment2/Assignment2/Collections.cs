using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Collections
    {
         static void Main()
        {
            List<Employee> employee = new List<Employee>();

            Console.WriteLine("---Employee Details---");
            Console.WriteLine();
            employee.Add(new Employee());
            ((Employee)employee[0]).EmpNo(1);
            ((Employee)employee[0]).Empname("Nitya");

            ((Employee)employee[0]).salary(17000);
            ((Employee)employee[0]).Calc();
            ((Employee)employee[0]).CalculateSalary();
            Console.WriteLine();


        }
    }
}
