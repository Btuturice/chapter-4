using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 2; x <= 100; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
