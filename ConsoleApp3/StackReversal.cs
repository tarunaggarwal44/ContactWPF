//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var abc = new List<string>();

//            Stack<int> stack = new Stack<int>();
//            stack.Push(1);
//            stack.Push(2);
//            stack.Push(3);
//            stack.Push(4);
//            stack.Push(5);

//            Console.WriteLine(stack.Count);
//            Reverse(stack);
//            Console.WriteLine(stack.Count);
//            Console.ReadLine();
//        }


//        static void Reverse(Stack<int> stack)
//        {
//            if (stack.Count == 0)
//            {
//                return;
//            }

//            var number = stack.Pop();
//            Reverse(stack);

//            Insert(stack, number);

//        }


//        static void Insert(Stack<int> stack, int number)
//        {
//            if (stack.Count == 0)
//            {
//                stack.Push(number);
//                return;
//            }

//            var element = stack.Pop();
//            Insert(stack, number);
//            stack.Push(element);
//        }




//    }
//}
