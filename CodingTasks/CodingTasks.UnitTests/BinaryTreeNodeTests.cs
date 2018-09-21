using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingTasks;

namespace CodingTasks.UnitTests
{
    [TestFixture]
    public class BinaryTreeNodeTests
    {
        [Test]
        public void Equals_SameNode_MustReturnTrue(){
            var zero = new BinaryTreeNode() { value = 0 };
            Assert.That(zero.Equals(zero), Is.True);
        }


        [Test]
        public void Equals_AnotherNodeWithSameValue_MustReturnTrue() {
            var zero = new BinaryTreeNode() { value = 0 };
            Assert.That(zero.Equals(new BinaryTreeNode() {value = 0}), Is.True);
        }

        [Test]
        public void Equals_AnotherNodeWithDifferentValue_MustReturnFalse() {
            var zero = new BinaryTreeNode() { value = 0 };
            var one = new BinaryTreeNode() { value = 1 };
            Assert.That(zero.Equals(one), Is.False);
        }

        [Test]
        public void Equals_DifferentSizedTrees_MustReturnFalse() {
            var zero = new BinaryTreeNode() { value = 0 };
            var one = new BinaryTreeNode() { value = 1 };
            var two = new BinaryTreeNode() { value = 2};
            one.left = zero;
            one.right = two;
            //    (1)
            //   /   \
            // (0)   (2)
            Assert.That(zero.Equals(one), Is.False);
        }

        [Test]
        public void Equals_SameFormTreesWithDifferentValues_MustReturnFalse() {
            BinaryTreeNode first = GetThreeNodeSymmetricTreeWithValues(new int[] { 0, 1, 2 });
            //    (1)
            //   /   \
            // (0)   (2)
            BinaryTreeNode second = GetThreeNodeSymmetricTreeWithValues(new int[] { 3, 4, 5 });
            //    (3)
            //   /   \
            // (4)   (5)
            Assert.That(first.Equals(second), Is.False);
        }

        [Test]
        public void Equals_SameFormTreesWithSameValuesInSameNodes_MustReturnTrue() {
            BinaryTreeNode first = GetThreeNodeSymmetricTreeWithValues(new int[] { 0, 1, 2 });
            //    (1)
            //   /   \
            // (0)   (2)
            BinaryTreeNode second = GetThreeNodeSymmetricTreeWithValues(new int[] { 0, 1, 2 });
            //    (1)
            //   /   \
            // (0)   (2)
            Assert.That(first.Equals(second), Is.True);
        }

        [Test]
        public void Equals_SameFormTreesWithSameValuesInDifferentNodes_MustReturnFalse() {
            BinaryTreeNode first = GetThreeNodeSymmetricTreeWithValues(new int[] { 0, 1, 2 });
            //    (1)
            //   /   \
            // (0)   (2)
            BinaryTreeNode second = GetThreeNodeSymmetricTreeWithValues(new int[] { 1, 0, 2 });
            //    (0)
            //   /   \
            // (1)   (2)
            Assert.That(first.Equals(second), Is.False);
        }

        [Test]
        public void Equals_DifferentTreesWithSameSubTree_MustReturnFalse() {
            var testTree1 = new BinaryTreeNode() {
                value = 1
                , left = new BinaryTreeNode() { value = 0 }
                , right = new BinaryTreeNode() {
                    value = 3 
                    , left = new BinaryTreeNode() { value = 2 }
                }
            };
            //    (1)
            //   /   \
            // (0)   (3)
            //      /   \
            //    (2)   null

            var testTree2 = new BinaryTreeNode() {
                value = 1
                , left = new BinaryTreeNode() { value = 0 }
                , right = new BinaryTreeNode() {
                    value = 3 
                    , left = new BinaryTreeNode() { value = 3 }
                }
            };
            //    (1)*
            //   /   \
            // (0)*  (3)*
            //      /   \
            //    (3)*  null 

            Assert.That(testTree1.Equals(testTree2), Is.False);
        }

        private static BinaryTreeNode GetThreeNodeSymmetricTreeWithValues(int[] values)
        {
            var zero = new BinaryTreeNode() { value = values[0] };
            var one = new BinaryTreeNode() { value = values[1] };
            var two = new BinaryTreeNode() { value = values[2] };
            one.left = zero;
            one.right = two;
            //    ([1])
            //    /   \
            // ([0]) ([2])
            return one;
        }
    }
}
