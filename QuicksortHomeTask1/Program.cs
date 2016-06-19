using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicksortHomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter range of array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter MAX numbers: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int numbers;

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numbers = rnd.Next(1, max);
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to sort the array");
            Console.ReadLine();
            
            //int[] arr = {2, 1, 10, 3, 5, 6, 9, 4,7 ,8 };

            Console.WriteLine();

           QuickSort(array, 0, array.Length - 1);

           foreach (int i in array)
           {
               Console.Write(i + " ");
           }

            Console.ReadLine();


        }


        public static void QuickSort(int[] array, int left, int right)
            {
                double pivot = array[(left + right) / 2];
                int l = left;
                int r = right;
                int t;

                while (l <= r)
                {
                    while (array[l]< pivot)
                    {
                        l++;
                    }
                    while (array[r]> pivot)
                    {
                        r--;
                    }
                    if (l <=r)
                    {
                        t = array[l];
                        array[l] = array [r];
                        array[r] = t;
                        l++;
                        r--;
                    }
                }

                if (left < r)
                {
                    QuickSort (array , left , r);
                }

                if (l < right)
                {
                    QuickSort (array, l , right);
                }

            }
            
    }
}
