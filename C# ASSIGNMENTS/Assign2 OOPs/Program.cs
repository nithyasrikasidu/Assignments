using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment2
{
    public class Employee
    {
      
        
           public int Empno;
        public string Empname;
        public double salary;
        public double HRA;
        public double TA;
        public double DA;
        public double PF;
        public double TDS;
        public double NetSalary;
        public double GrossSalary;
    
        public string EmpName
        {
            get
            {
                return Empname;
            }
            set
            {
                Empname = value;
            }
        }
        public int EmpNo
        {
            get { return Empno; }
            set { Empno = value; }

        }
        public void Sal()
        {
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void Calc()
        {
            if (salary <= 5000)
            {
                HRA = 10 * (salary / 100);
                TA = 5 * (salary / 100);
                DA = 15 * (salary / 100);
            }
            else if (salary < 10000)
            {
                HRA = 15 * (salary / 100);
                TA = 10 * (salary / 100);
                DA = 20 * (salary / 100);


            }
            else if (salary < 15000)
            {
                HRA = 20 * (salary / 100);
                TA = 15 * (salary / 100);
                DA = 25 * (salary / 100);

            }
            else if (salary < 20000)
            {
                HRA = 25 * (salary / 100);
                TA = 20 * (salary / 100);
                DA = 30 * (salary / 100);

            }
            else
            {
                HRA = 30 * (salary / 100);
                TA = 25 * (salary / 100);
                DA = 35 * (salary / 100);
            }
            GrossSalary = salary + HRA + TA + DA;


        }
        public void CalculateSalary()
        {
            PF = 10 * (GrossSalary / 100);
            TDS = 18 * (GrossSalary / 100);
            NetSalary = GrossSalary - (PF + TDS);
        }
        public void Display()
        {
            Console.WriteLine("employee no:" + Empno);
            Console.WriteLine("employee name:" + Empname);
            Console.WriteLine("employee salary:" + salary);
            Console.WriteLine("House rent allowances:" + HRA);
            Console.WriteLine("traveling allownces:{0}" + TA);
            Console.WriteLine("DA:{0}" + DA);
            Console.WriteLine("TDS:{0}" + TDS);
            Console.WriteLine("NetSalary:" + NetSalary);
            Console.WriteLine("Gross Salary:" + GrossSalary);
        }
        public static void Main()
        {
            Employee emp = new Employee();
            Console.WriteLine("enter employee no:");
            emp.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name:");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("enter employee salary:");
            emp.Sal();
            emp.Calc();
            emp.CalculateSalary();
            emp.Display();
            Console.ReadKey();

        }


          
        
    }
    
}
