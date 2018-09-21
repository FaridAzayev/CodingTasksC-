using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTasks
{
    public class BinaryTreeNode
    {
        public int value { get; set; }
        public BinaryTreeNode left { get; set; }
        public BinaryTreeNode right { get; set; }

        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;
            
            return Util.isBinaryTreesEqual(this, (BinaryTreeNode)obj);
        }
    }
}
