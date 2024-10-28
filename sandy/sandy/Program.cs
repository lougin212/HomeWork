using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7, 8, 10, 12 };
            Console.WriteLine("enter a key number1 ");
            int key = int.Parse(Console.ReadLine());
            int index = RecursionBinarySearsh(array, key, 0, array.Length - 1);
            Console.WriteLine("index of" + key + "=" + index);


            int[] arr1 = { 4, 5, 7, 9, 12, 15, 50, 60, 70 };
            Console.WriteLine("enter a key number2");
            int key1 = int.Parse(Console.ReadLine());
            int index1 = RecursionBinarySearsh1(arr1, key1);
            Console.WriteLine("index of " + key1 + "=" + index1);




        }
        public static int RecursionBinarySearsh(int[] array, int key, int start, int end)
        {
            int mid = (start + end) / 2;
            if (array[mid] == key)
                return mid;
            if (start > end)
            {
                // else  if (key > array[mid]) 

                return -1;
            }
            if (array[mid] > key)
            {
                return RecursionBinarySearsh(array, key, start, mid - 1);

            }
            return RecursionBinarySearsh(array, key, mid + 1, end);

              }/// 

            static int RecursionBinarySearsh1(int[] arr1, int key1)
        {
            int end = 0;
            int start = arr1.Length - 1;
            while (end <= start)
            {
                int mid = (end + start) / 2;
                if (key1 == arr1[mid])
                    return (mid + 1);
                if (key1 > arr1[mid])
                    end = mid + 1;
                else start = mid - 1;

            }
            return -1;
        }
        }
    }

        
   


