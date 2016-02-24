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
            double amount;
            while (true)
            {
                Console.WriteLine("Enter an hourly pay rate");
                amount = Convert.ToDouble(Console.ReadLine());


                if (amount > 5.65 && amount < 49.99)
                {
                    break;
                }
            }
        }
    }
}
