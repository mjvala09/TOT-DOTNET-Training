using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OperatorsInCS
    {
        int a = 10; int b = 5;
        public OperatorsInCS()
        {
            Console.WriteLine($"Sum: {a + b}");
            Console.WriteLine($"Is {a} greater than {b}? {a > b}");
            if (a > b && a is int)
            {
                Console.WriteLine("Both conditions are true.");
            }

            a += 2;
            Console.WriteLine($"New Value after increment: {a}");
        }
    }
}