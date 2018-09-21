using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    [TestFixture]
    public class BinaryTreeNodeTest
    {
        [Test]
        public void TestEquals()
        {
            var zero = new BinaryTreeNode();
            zero.value = 0;
            //(0)

            //Console.Out.WriteLine(zero.Equals(zero));
            Assert.AreEqual(zero, zero);

            var one = new BinaryTreeNode();
            one.value = 1;
            //(1)

            //Console.Out.WriteLine(zero.Equals(one));
            //Console.Out.WriteLine(one.Equals(zero));
            Assert.AreNotEqual(zero, one);

            var two = new BinaryTreeNode();
            two.value = 2;
            one.left = zero;
            one.right = two;
            //    (1)
            //   /   \
            // (0)   (2)

            //Console.Out.WriteLine(one.Equals(one));
            //Console.Out.WriteLine(one.Equals(two));
            Assert.AreNotEqual(new BinaryTreeNode() { value = 1}, one);

            var three = new BinaryTreeNode();
            three.value = 3;
            three.left = two;
            //    (3)
            //   /   \
            // (2)   null

            one.right = three;
            //    (1)
            //   /   \
            // (0)   (3)
            //      /   \
            //    (2)   null

            //Console.Out.WriteLine(one.Equals(three));
            //Console.Out.WriteLine(three.Equals(one));

            var testTree = new BinaryTreeNode()
            {
                value = 1
                ,
                left = new BinaryTreeNode() { value = 0 }
                ,
                right = new BinaryTreeNode()
                {
                    value = 3
                    ,
                    left = new BinaryTreeNode() { value = 2 }
                }
            };
            //    (1)*
            //   /   \
            // (0)*  (3)*
            //      /   \
            //    (2)*  null 

            //Console.Out.WriteLine(testTree.Equals(one));
            //Console.Out.WriteLine(one.Equals(testTree));
            Assert.AreEqual(one, testTree);

            Assert.Pass("Equals test passed");
        }
    }
}
