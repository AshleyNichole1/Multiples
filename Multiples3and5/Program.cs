using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int threes = 0;
            //multiples of 3 
            for (int i = 3; i <= 1000; i += 3)
            {
                threes += i;
            }

            Console.WriteLine($"Sum of the multiples of three: {threes}\n");
            //multiples of 5 
            int five = 0;
            for (int i = 5; i <= 1000; i += 5)
            {
                five += i;   
            }
            Console.WriteLine($"Sum of the multiples of five: {five}\n");

            //find the sum of all of the multiples
            Console.WriteLine($"Sum of the multiples of three and five: {five + threes}");
        }
    }
}
