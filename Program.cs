using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTestingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the are and perimeter of a circle
            Circle c = new Circle();
            //radius x =5
            double x = 5.0;
            double area = c.Area(x);
            area = Math.Round(area, 2);
            Console.WriteLine("Area of the given circle is {0}",area);

            double perimeter = c.Perimeter(x);
            Console.WriteLine("Perimeter of the given circle is {0} ",perimeter);
            Console.WriteLine(" ");

            //Testing the are and perimeter of a rectangle
            Rectangle r = new Rectangle();
            double y = 5.0;
            double z = 5.0;
            area = r.Area(y, z);
            Console.WriteLine("Area of the given Reactangle measurements is {0} ",area);
            perimeter = r.Perimeter(y, z);
            Console.WriteLine("Perimeter of the given Reactangle measurements is {0} ",perimeter);
            Console.WriteLine(" ");

            //Testing the are and perimeter of a Triangle
            Triangle t = new Triangle();
            double s1 = 5.0;
            double s2 = 6.0;
            double s3 = 7.0;

            area = t.Area(s1, s2, s3);
            Console.WriteLine("Area of the given Triangle measurements is {0} ",area);
            perimeter = t.Perimeter(s1, s2, s3);
            Console.WriteLine("Perimeter of the given Triangle measurements is {0} ",perimeter);

            Console.ReadLine();
        }
    }
}
