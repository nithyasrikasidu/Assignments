using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
   public class AssignQ6
    {
        public static void Main()
        {
            Console.WriteLine("--------SELECT OPTION----------");


            
            Console.WriteLine("Press 1 for Magazine");
            Console.WriteLine("Press 2 for Novel");
            Console.WriteLine("Press 3 for ReferenceBook");
            Console.WriteLine("Press 4 for Miscellaneous \n");
            Console.WriteLine("Enter ur option: ");


            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:

                    {

                        Console.WriteLine("Book_Id:1");
                        Console.WriteLine("Title: Hindu");
                        Console.WriteLine("Price: 400");
                        Console.WriteLine("Book Type: Magazine");


                        break;
                    }
                case 2:
                    {
  
                        Console.WriteLine("Book_Id:2");
                        Console.WriteLine("Title:True friend");
                        Console.WriteLine("Price: 250");
                        Console.WriteLine("Book Type: Novel");
                        break;
                    }
                case 3:
                    {
                  
                        Console.WriteLine("Book_Id:3");
                        Console.WriteLine("Title:ramayanam");
                        Console.WriteLine("Price: 950");
                        Console.WriteLine("Book Type: ReferenceBook");
                        break;
                    }
                case 4:
                    {
                      
                        Console.WriteLine("Book_Id:4");
                        Console.WriteLine("Title: crack ");
                        Console.WriteLine("Price: 400");
                        Console.WriteLine("Book Type: Miscellaneous");
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect option");
                    break;
            }

            Console.ReadKey();

        }
    }
}
