using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqAssignment
{
    public class Employee
    {
        int EmployeeID;
        string FirstName;
        string LastName;
        string Title;
        DateTime DOB;
        DateTime DOJ;
        string City;
        public Employee(int EmployeeID, string FirstName, string LastName, string Title, DateTime DOB, DateTime DOJ, string City)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.DOB = DOB;
            this.DOJ = DOJ;
            this.City = City;
        }
        public int EmployeeId
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }
        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string Lastname
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string title
        {
            get { return Title; }
            set { Title = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            set { DOB = value; }
        }
        public DateTime doj
        {
            get { return DOJ; }
            set { DOJ = value; }
        }
        public string city
        {
            get { return City; }
            set { City = value; }
        }
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"));
            empList.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"));
            empList.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "pune"));
            empList.Add(new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"));
            empList.Add(new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"));
            empList.Add(new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"));
            empList.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai"));
            empList.Add(new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai"));
            empList.Add(new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai"));
            empList.Add(new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune"));
            IEnumerable<Employee> query = from Employee in empList select Employee;
            foreach (var emp in empList)
            {
                Console.WriteLine("Employee: {0},{1},{2},{3},{4},{5},{6},{6}", emp.EmployeeId, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);

            }
            Console.WriteLine("------------");
            Console.WriteLine("Employee details whose location is not mumbai");
            IEnumerable<Employee> query2 = from Employee in empList
                                           where Employee.City != "Mumbai"
                                           select Employee;
            foreach (var emp in query2)
            {
                Console.WriteLine("Employee: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeId, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("----------------");
            Console.WriteLine("Employee details whose title is Asstmanager");
            IEnumerable<Employee> Query3 = from Employee in empList
                                           where Employee.title == "AsstManager"
                                           select Employee;
            foreach (var emp in Query3)
            {
                Console.WriteLine("Employee: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeId, emp.Firstname, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("----------");
            Console.WriteLine(" Employee details whose last name start with S");
            IEnumerable<Employee> Query4 = from Employee in empList
                                           where (Employee.Lastname.StartsWith("S"))
                                           select Employee;
            foreach (var emp in Query4)
            {
                Console.WriteLine("Employee: {0},{1},{2},{3},{4},{5}", emp.EmployeeId, emp.Lastname, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Employee details whose who have joined before 1/1/2015");
            IEnumerable<Employee> Query5 = from Employee in empList
                                           where Employee.DOJ < (new DateTime(2015, 1, 1))
                                           select Employee;
            foreach (var Employee in Query5)
            {
                Console.WriteLine("Employee: {0},{1},{2},{3},{4},{5},{6}", Employee.EmployeeId, Employee.Firstname, Employee.Lastname, Employee.title, Employee.dob, Employee.doj, Employee.city);
            }
            Console.WriteLine("------------");
            Console.WriteLine("Employee details whose date of birth is after 1/1/1990 ");
            IEnumerable<Employee> Query6 = from Employee in empList
                                           where Employee.DOB < (new DateTime(1990, 1, 1))
                                           select Employee;
            foreach (var emp in Query6)
            {
                Console.WriteLine("Employee: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.Firstname, emp.LastName, emp.title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("-------------");
            Console.WriteLine(" employee details whose Designation is Consultant and Associate");
            IEnumerable<Employee> Query7 = from Employee in empList
                                           where (Employee.title == "Consultant") || (Employee.Title == "Associate")
                                           select Employee;
            foreach (var emp in Query7)
            {
                Console.WriteLine("Employee: {0},{1},{2},{3},{4},{5},{6}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.Title, emp.dob, emp.doj, emp.city);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Total no of Employees");
            var result = empList.Count();
            Console.WriteLine("Print the Result    " + result);



            var Chennai = (from emp in empList where emp.City == "Chennai" select empList).Count();
            Console.WriteLine("Employee who is belonging to Chennai  " + Chennai);

            var EmployeeHighestID = (from emp in empList select emp.EmployeeID).Max();
            Console.WriteLine("Highest EmployeeID in EmployeeList is  " + EmployeeHighestID);

            var EmployeeDOJAfterJoined = (from emp in empList where emp.DOJ > (new DateTime(2015 / 1 / 1)) select emp).Count();
            Console.WriteLine(" Total No of Employees joined after 1/1/2015 are:" + EmployeeDOJAfterJoined);

            Console.WriteLine();
            Console.WriteLine("--------Total number of employees whose designation is not Associate--------");
            int resTitle = (from emp in empList where emp.Title != "Associate" select emp).Count();
            Console.WriteLine(resTitle);


            Console.WriteLine();
            Console.WriteLine("--------Employee based on City-------");
            var Citybased = from emp in empList
                            group emp by emp.City;
            foreach (var group in Citybased)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count());
            }


            Console.WriteLine();
            Console.WriteLine("-----Employee based on city and title-----");
            var CityTitle = (from emp in empList group emp by new { emp.City, emp.Title });
            foreach (var emp in CityTitle)
            { 
                Console.WriteLine("{0} = {1}", emp.Key, emp.Count());
            }

            Console.WriteLine();
            Console.WriteLine("----Employee who is Youngest----");
            var EmployeewhoisYoungest = (from emp in empList select emp.DOB).Max();           
            Console.WriteLine("Employee who is Youngest is:  " + EmployeewhoisYoungest);
            Console.ReadLine();
         }
         


    }
}           

 

