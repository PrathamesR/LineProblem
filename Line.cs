using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblem
{
    public class Line
    {
        public float x1, y1, x2, y2;

        public void  SetLine()
        {
            string []pt = new string[2];
            Console.WriteLine("\nEnter x and y cordinates of the first point");
            pt = Console.ReadLine().Split();
            x1 = float.Parse(pt[0]);
            y1 = float.Parse(pt[1]);


            Console.WriteLine("Enter x and y cordinates of the second point");
            pt = Console.ReadLine().Split();
            x1 = float.Parse(pt[0]);
            y1 = float.Parse(pt[1]);
        }
    }
}
