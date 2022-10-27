using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTestingProject
{
    [TestFixture]
    class TriangleTest
    {
        [Test]
        public void AreaTest()
        {
            Triangle t = new Triangle();
            double x = 5.0;
            double y = 6.0;
            double z = 7.0;
            double expectedValue = Math.Sqrt(216) ;
            double actualValue = t.Area(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void PerimeterTest()
        {
            Triangle t = new Triangle();
            double x = 5.0;
            double y = 6.0;
            double z = 7.0;
            double expectedValue = 18;
            double actualValue = t.Perimeter(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
