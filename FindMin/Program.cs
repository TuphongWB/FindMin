using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMin
{
    internal class Program
    {
        public static int MinValue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int index = MinValue(arr);
            Console.WriteLine("The smallest element in the array is: " + arr[index]);
            Console.ReadKey();
        }
    }
}
