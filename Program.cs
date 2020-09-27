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
            Console.WriteLine("Welcome to Line Comparison Computation\n");

            Line l1 = new Line();
            l1.SetLine();
            
            //Use Case 1
            Console.WriteLine("\nLength of Line : "+ UseCase1.CalculateLength(l1));

            //Use Case 2
            Console.WriteLine();
            Line l2 = new Line();
            Console.WriteLine("\nFor Line 2: ");
            l2.SetLine();
            if (UseCase2.CheckEquality(l1, l2))
                Console.WriteLine("The lines are same");
            else
                Console.WriteLine("The lines are different");

            //Use Case 3
            Console.WriteLine();
            UseCase3.IdentifyGreater(l1, l2);

            //Temp Read line before exit
            Console.ReadLine();
        }
    }
}
