using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineProblem.UseCases;

namespace LineProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Line Comparison Computation");

            Line l1 = new Line();
            l1.SetLine();
            
            //Use Case 1
            Console.WriteLine("Length of Line 1 : "+ UseCase1.CalculateLength(l1));

            //Temp Read line before exit
            Console.ReadLine();
        }
    }
}
