using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTestingProject
{
    [TestFixture]
    class CircleTest
    {
        [Test]
        public void AreaTest()
        {
            Circle c = new Circle();
            double r = 4.0;
            double expectedValue = Math.PI * Math.Pow(4, 2);
            Math.Round(expectedValue, 2);
            double actualValue = c.Area(r);
            Math.Round(actualValue, 2);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void PerimeterTest()
        {
            Circle c = new Circle();
            double r = 5.0;
            double expectedValue = 2 * Math.PI * 5.0;
            double actualValue = c.Perimeter(r);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
