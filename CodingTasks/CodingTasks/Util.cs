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
        public static bool isBinaryTreesEqual(BinaryTreeNode first, BinaryTreeNode second){
            if (first == null && second == null)
                return true;

            if ((first == null && second != null) || (first != null && second == null))
                return false;

            if (first.value != second.value)
                return false;

            return isBinaryTreesEqual(first.left, second.left) && isBinaryTreesEqual(first.right, second.right);
        }        
    }
}
