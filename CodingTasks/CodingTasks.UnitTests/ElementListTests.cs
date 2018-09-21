using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks.UnitTests
{
    [TestFixture]
    class ElementListTests
    {
        [Test]
        public void getElementCollectionTest()
        {
            var eList = new List<Element>();        
            eList.Add(new Element() { age = 1, num = 5 });
            eList.Add(new Element() { age = 1, num = 4 });
            eList.Add(new Element() { age = 21, num = 5 });
            eList.Add(new Element() { age = 21, num = 3, name = "b" });
            eList.Add(new Element() { age = 21, num = 3, name = "a" });

            Assert.AreEqual(eList.getElementCollection().Count, 2);
            Assert.Pass("getElementCollection test passed");
        }
    }
}
