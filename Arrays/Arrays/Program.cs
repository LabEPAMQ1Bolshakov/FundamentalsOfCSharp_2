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
            Console.WriteLine("Enter the number of rows in the arrays:");
            string str = Console.ReadLine();
            int rowsArr;
            while (Int32.TryParse(str, out rowsArr) == false)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine("Enter the number of rows in the arrays:");
                str = Console.ReadLine();
            }
            
            Console.WriteLine("Enter the number of columns in the arrays:");
            str = Console.ReadLine();
            int columnArr;
            while (Int32.TryParse(str, out columnArr) == false)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine("Enter the number of columns in the arrays:");
                str = Console.ReadLine();
            }            
            Console.WriteLine();
            
            int[,] arr1 = new int[rowsArr,columnArr];
            int[,] arr2 = new int[rowsArr,columnArr];

            Console.WriteLine("Array 1:");
            ReadArray(arr1, rowsArr, columnArr);            
            Console.WriteLine("Array 1 has been written down.");
            Console.WriteLine();

            Console.WriteLine("Array 2:");
            ReadArray(arr2, rowsArr, columnArr);            
            Console.WriteLine("Array 2 has been written down.");            
            Console.WriteLine();
                       
            Console.WriteLine("Their sum is:");                    
            WriteArray(arr1, rowsArr, columnArr);
            Console.WriteLine();
            Console.WriteLine("+");
            Console.WriteLine();
            WriteArray(arr2, rowsArr, columnArr);
            Console.WriteLine();
            Console.WriteLine("=");
            Console.WriteLine();

            int[,] arr3 = new int[rowsArr, columnArr];
            for (int i = 0; i <= rowsArr - 1; i++)
            {
                for (int j = 0; j <= columnArr - 1; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            WriteArray(arr3, rowsArr, columnArr);
            
            Console.ReadKey();
        }

        static void ReadArray(int[,] arr, int rowsArr, int columnArr)
        {
            for (int i = 0; i <= rowsArr - 1; i++)
            {
                for (int j = 0; j <= columnArr - 1; j++)
                {
                    Console.WriteLine("Enter the [{0},{1}] member", i + 1, j + 1);                    
                    string str = Console.ReadLine();
                    if (Int32.TryParse(str, out arr[i, j]))
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write("Wrong input!");
                        Console.WriteLine();
                        j--;
                    }
                }
            }
        }

        static void WriteArray(int[,] arr, int rowsArr, int columnArr)
        {
            for (int i = 0; i <= rowsArr - 1; i++)
            {
                for (int j = 0; j <= columnArr - 1; j++)
                {
                    Console.Write("{0,3} ", arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
