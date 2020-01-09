using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BinaryTrees
{
    public interface IBinaryTree
    {
        void InsertNodeByKey(int key, object data);
        void DeleteNodeByKey(int key);
        BinaryTreeNode Search(int key);
    }
}
