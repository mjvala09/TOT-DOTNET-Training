using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private int EngineNumber {  get; set; }
        public string Model { get; set; }
        protected string Brand { get; set; }
        internal int Year { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine(
                $"EngineNumber : {EngineNumber}\n" +
                $"Model : {Model}\n" +
                $"Brand : {Brand}\n" +
                $"Year : {Year}"
            );
        }
    }
}
