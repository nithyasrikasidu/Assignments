using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionToSqlServer
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // Insert();
            // update();
            Delete();


        }
        static void Insert()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=NithyaVM;Initial catalog=employee;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Please Enter Employee Id : ");
            int Emp_Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Employee Name : ");
            String Emp_Name = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Salary : ");
            int Emp_Salary = Convert.ToInt32(Console.ReadLine());


            string insertQuery = "insert into EmpTab(Emp_ID, Emp_name ,Emp_Salary) Values('" + Emp_Id + "','" + Emp_Name + "', '" + Emp_Salary + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlConnection.Close();
        }


        static void update()
        {
            //connecting to the database
            SqlConnection sqlConnection;
            string connectionstring = @"Data Source=NithyaVM; Initial catalog=employee; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionstring);
            //opening of the database
            sqlConnection.Open();
            try
            {
                //used to display the statement
                Console.WriteLine("enter the id value that u want to update");
                //parse is used to convert string to int
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the name to be updated");
                string name = Convert.ToString(Console.ReadLine());
                string updatquery = "update EmpTab set Emp_Name= '" + name + "' where Emp_ID= " + id + "";
                SqlCommand updatecommand = new SqlCommand(updatquery, sqlConnection);
                //to execute the updated data
                updatecommand.ExecuteNonQuery();
                Console.WriteLine("updated data successfully");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        static void Delete()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=NithyaVM; Initial catalog=employee; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            try
            {
                Console.WriteLine("enter the id value that u want to delete ");
                int Emp_ID = int.Parse(Console.ReadLine());

                string deletequery = "delete from EmpTab where Emp_ID=" + Emp_ID;
                SqlCommand deleteCommand = new SqlCommand(deletequery, sqlConnection);

                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("deleted data successfully");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

