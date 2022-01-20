using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Node
    {
        public int Data { get; private set; }
        public Node Next { get; private set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }

    public static class LinkedListToString
    {
        public static string Stringify(Node list)
            => list == null ? "null" : $"{list.Data} -> {Stringify(list.Next)}";
    }
}
