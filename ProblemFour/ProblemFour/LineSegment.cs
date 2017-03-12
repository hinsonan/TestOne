using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFour
{
    struct LineSegment 
    {
        
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public double Slope {
            get
            {
                double m = (EndPoint.y - StartPoint.y) / (EndPoint.x - StartPoint.x);
                return m;
            }
        }
        public Point Midpoint {
            get
            {
                double x = (StartPoint.x + EndPoint.x) / 2;
                double y = (StartPoint.y + EndPoint.y) / 2;
                Point midPoint = new Point(x, y);
                return midPoint;
            }
                
                }
        public double Length {
            get
            {
                return StartPoint.x + EndPoint.y;
            }
        }

        public LineSegment(Point s, Point e)
        {
            StartPoint = s;
            EndPoint = e;
            

        }

        public override string ToString()
        {
            return $"{StartPoint},{EndPoint}";
        }






    }
}
