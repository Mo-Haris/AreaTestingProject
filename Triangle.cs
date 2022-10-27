using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTestingProject
{
    class Triangle
    {
        public double Area(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s*(s - sideA)*(s - sideB)*(s - sideC));
            return area;
        }
        public double Perimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }
    }
}
