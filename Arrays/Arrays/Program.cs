using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsArr = ReadNumOfRows();
            int columnArr = ReadNumOfColumns();
            Console.WriteLine("\n");

            int[,] arr1 = new int[rowsArr,columnArr];
            int[,] arr2 = new int[rowsArr,columnArr];

            Console.WriteLine("Array 1:");
            ReadArray(arr1, rowsArr, columnArr);            
            Console.WriteLine("Array 1 has been written down.\n");
            
            Console.WriteLine("Array 2:");
            ReadArray(arr2, rowsArr, columnArr);            
            Console.WriteLine("Array 2 has been written down.\n");     
                       
            Console.WriteLine("Their sum is:");                    
            WriteArray(arr1, rowsArr, columnArr);            
            Console.WriteLine("+\n");
            WriteArray(arr2, rowsArr, columnArr);
            Console.WriteLine("=\n");

            int[,] arr3 = new int[rowsArr, columnArr];
            AddArray(rowsArr, columnArr, arr1, arr2, arr3);
            WriteArray(arr3, rowsArr, columnArr);
            
            Console.ReadKey();
        }

        public static int ReadNumOfRows()
        {
            Console.WriteLine("Enter the number of rows in the arrays:");
            string str = Console.ReadLine();
            int rowsArr;
            while (Int32.TryParse(str, out rowsArr) == false)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine("Enter the number of rows in the arrays:");
                str = Console.ReadLine();
            }
            return rowsArr;
        }

        public static int ReadNumOfColumns()
        {
            Console.WriteLine("Enter the number of columns in the arrays:");
            string str = Console.ReadLine();
            int columnArr;
            while (Int32.TryParse(str, out columnArr) == false)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine("Enter the number of columns in the arrays:");
                str = Console.ReadLine();
            }
            return columnArr;
        }

        static void ReadArray(int[,] arr, int rowsArr, int columnArr)
        {
            for (int i = 0; i < rowsArr; i++)
            {
                for (int j = 0; j < columnArr; j++)
                {
                    Console.WriteLine("Enter the [{0},{1}] member", i + 1, j + 1);                    
                    string str = Console.ReadLine();
                    if (Int32.TryParse(str, out arr[i, j]) == false)                    
                    {
                        Console.Write("Wrong input!\n");
                        j--;
                    }
                }
            }
        }

        static void AddArray(int rowsArr, int columnArr, int[,] arr1, int[,] arr2, int[,] arr3)
        {
            for (int i = 0; i < rowsArr; i++)
            {
                for (int j = 0; j < columnArr; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }           
        }


        static void WriteArray(int[,] arr, int rowsArr, int columnArr)
        {
            for (int i = 0; i < rowsArr; i++)
            {
                for (int j = 0; j < columnArr; j++)
                {
                    Console.Write("{0,3} ", arr[i,j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
