using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BinaryTrees
{
    public class BinaryTree : IBinaryTree
    {
        public BinaryTreeNode Root { get; set; }

        public void DeleteNodeByKey(int key)
        {
            throw new NotImplementedException();
        }

        public void InsertNodeByKey(int key, object data)
        {
            throw new NotImplementedException();
        }

        public BinaryTreeNode Search(int key)
        {
            return this.RecursiveSearch(key, Root);
        }

        private BinaryTreeNode RecursiveSearch(int key, BinaryTreeNode node)
        {
            if (key > node.NodeKey)
            {
                return RecursiveSearch(key, Root.Right);
            }
            else if(key < node.NodeKey)
            {
                return RecursiveSearch(key, Root.Left);
            }
            else
            {
                return node;
            }
        }
    }
}
