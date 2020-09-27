using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblem.UseCases
{
    public class UseCase1
    {
        public static double CalculateLength(Line line)
        {
            return Math.Sqrt((line.x1 - line.x2) * (line.x1 - line.x2) + (line.y1 - line.y2) * (line.y1 - line.y2));
        }
    }
}
