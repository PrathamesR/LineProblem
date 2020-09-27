using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblem.UseCases
{
    public class UseCase2
    {
        public static bool CheckEquality(Line line1, Line line2)
        {
            if ((line1.x1 == line2.x1 && line1.y1 == line2.y1) && (line1.x2 == line2.x2 && line1.y2 == line2.y2))
                return true;
            else if ((line1.x1 == line2.x2 && line1.y1 == line2.y2) && (line1.x2 == line2.x1 && line1.y2 == line2.y1))
                return true;
            
            else return false;
        }
    }
}
