using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTestingProject
{
    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void AreaTest()
        {
            Rectangle r = new Rectangle();
            double x = 5.0;
            double y = 5.0;
            double expectedValue = 25.0;
            double actualvalue = r.Area(x, y);
            Assert.AreEqual(expectedValue, actualvalue);
        }
        [Test]
        public void PerimeterTest()
        {
            Rectangle r = new Rectangle();
            double x = 5.0;
            double y = 5.0;
            double expectedValue = 20.0;
            double actualvalue = r.Perimeter(x, y);
            Assert.AreEqual(expectedValue, actualvalue);
        }
    }
}
