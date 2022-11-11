using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class AssignQ4
    {
     public static void Main()
        {
            int num1, num2, temp;
            Console.WriteLine("enter first integer");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second integer");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("After Swapping : ");
            Console.Write("\n First integer : " + num1);
            Console.Write("\n Second integer : " + num2);
            Console.Read();
        }
    }

}
