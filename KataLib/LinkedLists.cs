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

        public static Node Push(Node head, int data)
            => new Node(data, head);

        public static Node BuildOneTwoThree()
            => new Node(1, new Node(2, new Node(3)));

        public static int Length(Node head)
            => head == null ? 0 : 1 + Length(head.Next);

        public static int Count(Node head, Predicate<int> func)
            => head == null ? 0
                    : func(head.Data) == true ? 1 + Count(head.Next, func)
                    : Count(head.Next, func);
    }

    public static class LinkedLists
    {
        public static string Stringify(Node list)
            => list == null ? "null" : $"{list.Data} -> {Stringify(list.Next)}";
    }

}
