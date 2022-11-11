using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Assignment3.Assignment3.EmployeeManagementSystem;

namespace Assignment3
{
    internal class Assignment3
    {
        public interface Iprintable
        {
            void print();
        }
        public class EmployeeManagementSystem:Iprintable
        {
            public int salary;

            public void print()
            {
                Console.WriteLine(" enter the first name of the employee:");
                string FirstName = Console.ReadLine();
                Console.WriteLine(" enter the last name of the employee:");
                string lastname = Console.ReadLine();
                Console.WriteLine(" enter employee salary");
                salary = Convert.ToInt32(Console.ReadLine());
                if (salary <= 0 || salary > 20000)
                {
                    Console.WriteLine("please enter a valid value again from starting");
                    print();
                }
                else if (salary < 5000)
                {
                    Console.WriteLine(" employee name: {0}", FirstName + lastname);
                    Console.WriteLine("net salary: {0}", salary);

                    int PF = 8 * (salary / 100);
                    Console.WriteLine("gross salary: {0}", salary + PF);

                }
                else if (salary > 5000 && salary < 10000)
                {
                    Console.WriteLine(" employee name: {0}", FirstName + lastname);
                    Console.WriteLine("net salary: {0}", salary);

                    int PF = 9 * (salary / 100);
                    Console.WriteLine("gross salary: {0}", salary + PF);
                }
                else if (salary > 10000 && salary < 20000)
                {
                    Console.WriteLine(" employee name: {0}", FirstName + lastname);
                    Console.WriteLine("net salary: {0}", salary);

                    int PF = 10 * (salary / 100);
                    Console.WriteLine("gross salary: {0}", salary + PF);
                }


              
            }

            public class Manager:EmployeeManagementSystem
            {
                private double PetrollAllowance;
                private double FoodAllowances;
                private double otherAllowance;


                public void calculate()
                {
                    Console.WriteLine("enter salary of manager:");
                    salary = Convert.ToInt32(Console.ReadLine());
                    PetrollAllowance = 8 * (salary / 100);
                    FoodAllowances = 9 * (salary / 100);
                    otherAllowance = 10 * (salary / 100);

                    Console.WriteLine("gross salary of manager = {0}", salary + PetrollAllowance + FoodAllowances + otherAllowance);

                }

                public void calculateSalary()
                {
                    Console.WriteLine("net salary of manager = {0}", salary);
                }

            }

            public class MarketingExecutive : EmployeeManagementSystem
            {
                private int kiloMeterTravel;
                private int TourAllowances;
                private int TelephoneAllowances; 

                public void Calculate()
                {
                    Console.WriteLine("enter Marketing Executive Salary:");
                    salary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter kilometer travel by marketing executive:");
                    kiloMeterTravel = Convert.ToInt32(Console.ReadLine());
                    TourAllowances = kiloMeterTravel * 5;
                    TelephoneAllowances = 1000;
                    Console.WriteLine("gross salary of marketing executive:{0}",salary + kiloMeterTravel + TourAllowances);
                }

                public void CalculateSalary()
                {
                    Console.WriteLine("net salary of marketing executive: {0}" + salary);
                }

                
                

            }

            public class AssignQ1
            {
                public static void Main()
                {
                    NewMethod();

                }

                private static void NewMethod()
                {
                    Iprintable IP = new EmployeeManagementSystem();
                    IP.print();
                    EmployeeManagementSystem.Manager manager = new Manager();
                    manager.calculate();
                    manager.calculateSalary();

                    EmployeeManagementSystem.MarketingExecutive ME = new MarketingExecutive();
                    ME.Calculate();
                    ME.CalculateSalary();
                    Console.ReadLine();

                }
            }

             
            
        }
    }   
}
