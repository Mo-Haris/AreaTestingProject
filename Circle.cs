using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTestingProject
{
    class Circle
    {
        public double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Perimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
