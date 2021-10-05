using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class SumTheTree
    {
        public static int SumTree(Node root)
            => root == null ? 0 : root.Value + SumTree(root.Left) + SumTree(root.Right);
    }

    //public static int SumTree(Node root)
    //        => root.Value
    //            + (root.Left != null ? SumTree(root.Left) : 0)
    //            + (root.Right != null ? SumTree(root.Right) : 0);

    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
