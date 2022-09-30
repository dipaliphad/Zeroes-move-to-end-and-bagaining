using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroes_move
{
    internal class Program
    {

        //move zeroes to begaing and end of array...
        static void pushZerosToBegaining(int[] arr, int n)
        {
            int count = arr.Length -1;
            for (int i = count; i >= 0; i--)
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count--;
                }
            while (count >= 0)
            {
                arr[count] = 0;
                count--;
            }
        }
        public static void Main()
        {
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            int n = arr.Length;
            pushZerosToBegaining(arr, n);
            Console.WriteLine(" all zeros to begaining: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            //static void pushZerosToEnd(int[] arr, int n)
            //{

            //    int count = 0;
            //    for (int i = 0; i < n; i++)
            //        if (arr[i] != 0)

            //            arr[count++] = arr[i];

            //    while (count < n)
            //        arr[count++] = 0;
            //}
            //public static void Main()
            //{
            //int[] arr = { 2, 10, 0, 5,3,0,4,1};
            //    int n = arr.Length;
            //    pushZerosToEnd(arr, n);
            //Console.WriteLine(" all zeros to end: ");
            //    for (int i = 0; i < n; i++)
            //        Console.Write(arr[i] + " ");
        }
        }
    }
    

