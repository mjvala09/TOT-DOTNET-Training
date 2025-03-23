using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Datatypes
    {
        int d1 = 100;
        double d2 = 99.99;
        bool d3 = true;
        string d4 = "Hello, C#";
        public Datatypes()
        {
            Console.WriteLine($"Integer : {d1}\nFloating-point: {d2}\nBoolean : {d3}\nString : {d4}");
        }
    }
}