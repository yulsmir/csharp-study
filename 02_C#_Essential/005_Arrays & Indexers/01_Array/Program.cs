using System;
using System.Linq;

namespace _01_Array
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 24, 18, 23, 45, 104, 2, 13, 71, 22, 1, 17 };

            /*Print array*/
            foreach (var item in array)
            {
                item.ToString();
            }

            Console.WriteLine("Array is [{0}]", string.Join(", ", array));

            /* Sum */
            int arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                arraySum += array[i];
            }

            /* Average */
            double arrayAverage = arraySum / array.Length - 1;

            /* Array element is unEven */
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine("uneven " + array[i]);
                }
            }

            /* Max array element */
            int arrayMax = array.Max();

            /* Min array element */
            int arrayMin = array.Min();

            Console.WriteLine("Array is " + array);
            Console.WriteLine("Array sum is " + arraySum);
            Console.WriteLine("Array average is " + arrayAverage);
            Console.WriteLine("Array max is " + arrayMax);
            Console.WriteLine("Array min is " + arrayMin);

            Console.ReadKey();

        }


    }
}
