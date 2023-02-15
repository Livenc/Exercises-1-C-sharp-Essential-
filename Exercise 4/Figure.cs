using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Figure
    {
        Point a, b, c, d, s;

        public Figure(Point a, Point b, Point c)
        {
            this.a = a; 
            this.b = b;
            this.c = c;
            
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c; 
            this.d = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point s)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
            this.d = d; 
            this.s = s;
        }

        double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X-a.X,2)+Math.Pow(b.Y-a.Y,2));
        }
        public void PerimeterCalculator()
        {
            double x;
            if (d == null)
            {
                x = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, a);
                Console.WriteLine("Triangle");
            }else if(s == null)
            {
               x = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d)+ LengthSide(c, a);
                Console.WriteLine("Quadrilateral");
            }
            else
            {
                x = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, s) + LengthSide(s, a);
                Console.WriteLine("Pentagon");
            }
            
            Console.WriteLine(x);
        }
    }   
}
