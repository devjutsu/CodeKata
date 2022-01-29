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

        public static Node GetNth(Node node, int index)
            => node == null ? throw new ArgumentException() 
                        : index == 0 ? node 
                            : GetNth(node.Next, index - 1);

        public static Node InsertNth(Node head, int index, int data)
        {
            if (index == 0)
                return new Node(data, head);
            else if (index < 0) throw new ArgumentOutOfRangeException();

            var item = head;
            for (var i = 0; i < index - 1; i++)
            {
                if (item.Next == null)
                    throw new ArgumentOutOfRangeException();
                item = item.Next;
            }
            item.Next = new Node(data, item.Next);
            return head;
        }

        // public static Node InsertNth(Node head, int index, int data)
        // {
        //     if (index < 0) { throw new ArgumentOutOfRangeException("Second argument must not be negative."); }
        //     if (index > 0 && head == null) { throw new ArgumentOutOfRangeException("Second argument is out of bounds of the linked list."); }

        //     if (index == 0) { return new Node(data, head); }
        //     head.Next = InsertNth(head.Next, --index, data);

        //     return head;
        // }
    }

    public static class LinkedLists
    {
        public static string Stringify(Node list)
            => list == null ? "null" : $"{list.Data} -> {Stringify(list.Next)}";
    }

}
