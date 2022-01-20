using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class SumTheTree
    {
        public static int SumTree(TreeNode root)
            => root == null ? 0 : root.Value + SumTree(root.Left) + SumTree(root.Right);
    }

    //public static int SumTree(Node root)
    //        => root.Value
    //            + (root.Left != null ? SumTree(root.Left) : 0)
    //            + (root.Right != null ? SumTree(root.Right) : 0);

    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value, TreeNode left = null, TreeNode right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
