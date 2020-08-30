using System;

namespace ConsoleApp3
{


    class Node
    {
        public int value;
        public Node next;

        public Node(int v)
        {
            value = v;
        }
    }

    class Linked
    {
        public Node head;
    }


    class Program
    {

        static void Main(string[] args)
        {
            Node first = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            Linked linkedList = new Linked();
            linkedList.head = first;

            first.next = second;
            second.next = third;


            var start = linkedList.head;

            while (start != null)
            {
                Console.WriteLine(start.value);
                start = start.next;
            }


            var n = ReverseLinkedList(linkedList.head, linkedList.head.next);

            while (n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }


            Console.ReadLine();
        }

        static Node ReverseLinkedList(Node prev, Node current)
        {
            Node head;
            if (current.next == null)
            {
                current.next = prev;
                return current;
            }

            head = ReverseLinkedList(prev.next, current.next);

            current.next = prev;
            prev.next = null;


            return head;
        }


    }
}
