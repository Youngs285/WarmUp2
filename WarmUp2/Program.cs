using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarmUp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter A Number: ");
                int n;
                string input = Console.ReadLine();

                n = Convert.ToInt32(input);

                Console.Write("W");
                for (int i = 0; i < n; i++)
                {
                    Console.Write('o');
                }
                Console.WriteLine("W!");
            }
        }
    }
}
