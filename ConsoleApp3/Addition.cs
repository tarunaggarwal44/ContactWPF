//using System;
//using System.Collections.Generic;
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


//            //var total = deno(6, 2);
//            //Console.WriteLine(total);
//            //Console.ReadLine();

//            var number = "129";
//            var carry = 0;
//            var output = Add(number, 1);
//            // Number of disks 
//            //int n = 4;

//            //// A, B and C are names of rods 
//            //towerOfHanoi(n, 'A', 'C', 'B');
//            //var a = fun1(5);
//            Console.WriteLine(output);
//            Console.ReadLine();
//        }




//        static int deno(int amount, int denomination)
//        {
//            var total = 0;
//            if (amount < denomination)
//            {
//                return total;
//            }

//            total = total + 1;
//            amount = amount - denomination;

//            total = total + deno(amount, denomination);
//            return total;
//        }


//        static string Add(string input, int number)
//        {
//            var result = Addition(input, number);
//            string output;
//            if (result.Item2 == 1)
//            {
//                output = result.Item2 + result.Item1;
//            }

//            else
//            {
//                output = result.Item1;
//            }

//            return output;
//        }
//        static Tuple<string, int> Addition(string input, int number)
//        {
//            var output = "";
//            var carry = 0;

//            if (input.Length == 1)
//            {
//                var addOutput = GetAddtionResult(input, number);
//                return addOutput;
//            }


//            var result = Addition(input.Substring(1, input.Length - 1), number);
//            output = output + result.Item1;

//            var add1 = Convert.ToInt32(input.Substring(0, 1)) + result.Item2;
//            if (add1 > 9)
//            {
//                carry = 1;
//                output = Convert.ToString(add1 % 10) + output;
//            }

//            else
//            {
//                output = Convert.ToString(add1) + output;
//            }

//            return new Tuple<string, int>(output, carry);
//        }

//        private static Tuple<string, int> GetAddtionResult(string input, int number)
//        {
//            var carry = 0;
//            var add = Convert.ToInt32(input) + number;
//            string output;
//            if (add > 9)
//            {
//                carry = 1;
//                output = Convert.ToString(add % 10);
//            }

//            else
//            {
//                output = Convert.ToString(add);
//            }

//            return new Tuple<string, int>(output, carry);
//        }

//        static void towerOfHanoi(int n, char from_rod,
//                           char to_rod, char aux_rod)
//        {
//            if (n == 1)
//            {
//                Console.WriteLine("Move disk 1 from rod " + from_rod
//                                               + " to rod " + to_rod);
//                return;
//            }
//            towerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
//            Console.WriteLine("Move disk " + n + " from rod "
//                              + from_rod + " to rod " + to_rod);
//            towerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
//        }


//        static int fun1(int n)
//        {
//            if (n == 1 || n == 2)
//                return 1;

//            var a = fun1(n - 2) + fun1(n - 1);
//            return a;
//        }


//    }
//}
