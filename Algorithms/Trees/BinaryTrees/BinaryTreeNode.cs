using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BinaryTrees
{
    public class BinaryTreeNode
    {
        public int NodeKey { get; set; }
        public object Data { get; set; }

        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
    }
}
