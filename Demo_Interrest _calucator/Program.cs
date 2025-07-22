using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interrest__calucator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("here goal is to work with numeric types and maths formulae ");
            Console.WriteLine("Enter the principle amount");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time in years");
            double time = Convert.ToDouble(Console.ReadLine());
            double interest = (principle * rate * time) / 100;
            Console.WriteLine($"The interest is {interest}");
        }
    }
}
