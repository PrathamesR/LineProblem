using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblem.UseCases
{
    public class UseCase3
    {
        public static void IdentifyGreater(Line line1, Line line2)
        {
            if (UseCase1.CalculateLength(line1) > UseCase1.CalculateLength(line2))
                Console.WriteLine("The First Line is Longer");
            else if (UseCase1.CalculateLength(line1) < UseCase1.CalculateLength(line2))
                Console.WriteLine("The Second Line is Longer");
            else
                Console.WriteLine("Both Lines are equal in length");
        }
    }
}
