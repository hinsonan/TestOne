using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3);
            Point p2 = new Point(8, 9);

            LineSegment line = new LineSegment(p1, p2);
            Console.WriteLine(line.ToString());
            Console.WriteLine($"Midpoint: {line.Midpoint}  Slope: {line.Slope}  Length: {line.Length}");

            Console.ReadKey();
        }
    }
}
