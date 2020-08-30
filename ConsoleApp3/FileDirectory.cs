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
//            var path = @"C:\Users\taruna\Desktop\Test";

//            var filePaths = GetDirectories(path);

//            foreach (var filePath in filePaths)
//            {
//                Console.WriteLine(filePath);
//            }

//            Console.ReadLine();
//        }





//        static List<string> GetDirectories(string path)
//        {
//            var orderFilePaths = new List<string>();

//            string[] directoriesPaths = Directory.GetDirectories(path);
//            string[] filePaths = Directory.GetFiles(path);

//            foreach (var directoriesPath in directoriesPaths)
//            {
//                var result = GetDirectories(directoriesPath);
//                orderFilePaths.AddRange(result);
//            }



//            foreach (var filePath in filePaths)
//            {
//                orderFilePaths.Add(filePath);
//                //Console.WriteLine(filePath);
//            }

//            return orderFilePaths;
//        }


//        static void spiral(int[,] matrix, int i, int j, int imin, int imax, int jmin, int jmax)
//        {

//            if (imin <= imax)
//                Console.WriteLine(matrix[i, j]);

//            if (j < jmax)
//            {
//                j++;
//                spiral(matrix, i, j, imin, imax, jmin, jmax);
//            }

//            imin = imin + 1;


//            if (i < imax)
//            {
//                i++;
//                spiral(matrix, i, j, imin, imax, jmin, jmax);
//            }
//            jmax = jmax - 1;

//            if (j > jmin)
//            {
//                j--;
//                spiral(matrix, i, j, imin, imax, jmin, jmax);
//            }

//            imax = imax - 1;
//            //jmin = jmin + 1;



//            if (i > imin)
//            {
//                i--;
//                spiral(matrix, i, j, imin, imax, jmin, jmax);
//            }

//            jmin = jmin + 1;
//            // imin = imin + 1;


//        }


//    }
//}
