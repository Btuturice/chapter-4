using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input;

            do
            {
                 Console.WriteLine("Enter any number!");
                 input = Convert.ToInt32(Console.ReadLine());

                 if (input == 999)
                     break;

                 sum = sum + input;

             } while (input != 999);

            Console.WriteLine("The sum is " + sum);
             
         }
     }
}

