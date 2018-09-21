using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    public class Util
    {
        /// <summary>Recursively checks two trees node by node </summary>
        /// <returns>true if every tree has same valu at the same place</returns>
        public static bool isBinaryTreesEqual(BinaryTreeNode root1, BinaryTreeNode root2){
            if (root1 == null && root2 == null)
                return true;

            if ((root1 == null && root2 != null) || (root1 != null && root2 == null))
                return false;

            if (root1.value != root2.value)
                return false;

            return isBinaryTreesEqual(root1.left, root2.left) && isBinaryTreesEqual(root1.right, root2.right);
        }        
    }
}
