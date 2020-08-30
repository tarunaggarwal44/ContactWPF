//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{


//    class Node
//    {
//        public int value;
//        public Node next;

//        public Node(int v)
//        {
//            value = v;
//        }
//    }

//    class Linked
//    {
//        public Node head;
//    }


//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Node first = new Node(1);
//            Node second = new Node(2);
//            Node third = new Node(3);

//            Linked linkedList = new Linked();
//            linkedList.head = first;

//            first.next = second;
//            second.next = third;


//            var start = linkedList.head;

//            while (start != null)
//            {
//                Console.WriteLine(start.value);
//                start = start.next;
//            }


//            var n = ReverseLinkedList(linkedList.head);

//            while (n != null)
//            {
//                Console.WriteLine(n.value);
//                n = n.next;
//            }


//            Console.ReadLine();
//        }

//        static Node ReverseLinkedList(Node node)
//        {
//            Node reverseNode;
//            if (node == null)
//            {
//                return null;
//            }

//            reverseNode = ReverseLinkedList(node.next);
//            Node newNode = new Node(node.value);


//            if (reverseNode == null)
//            {
//                reverseNode = newNode;
//            }

//            else
//            {
//                Node temp = reverseNode;
//                while (temp.next != null)
//                {
//                    temp = temp.next;
//                }

//                temp.next = newNode;
//            }


//            return reverseNode;
//        }


//    }
//}
