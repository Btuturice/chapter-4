using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            char vowel;
            while (true)
            {
                Console.WriteLine("Enter a vowel");
                vowel = Convert.ToChar(Console.ReadLine().ToLower());

                while (true)
                {
                    if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                    {
                        Console.WriteLine("OK");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                        break;
                    }
                }
            }
        }
    }
}
