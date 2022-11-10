using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             private int[] ele;
        private int top;
        private int max;
        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }



        public void push(int item)
        {
            try
            {
                if (top == max - 1)
                {
                    Console.WriteLine("Stack Overflow");

                }
                else
                {
                    ele[++top] = item;
                }
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e);
            }
        }



        public int pop()
        {


            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + ele[top]);
                return ele[top--];
            }







        }



        public void printStack()
        {
            try
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return;
                }
                else
                {
                    for (int i = 0; i <= top; i++)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                    }
                }
            }
            catch (InsufficientExecutionStackException e)
            {
                Console.WriteLine(e);
            }
        }
    }



    class Program
    {
        static void Main()
        {
            Stack S = new Stack(5);



            S.push(10);
            S.push(20);
            S.push(30);
            S.push(40);
            S.push(50);
            S.push(8);




            Console.WriteLine("Items are : ");
            S.printStack();



            S.pop();
            S.pop();
            S.pop();



            Console.ReadKey();
        }
    }
}
