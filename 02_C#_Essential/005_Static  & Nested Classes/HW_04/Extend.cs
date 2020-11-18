using System;
using System.Collections.Generic;
using System.Text;

namespace HW_04
{
    static class Extend
    {
        public static void ArraySortUp(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] > array[j])
                    {
                        int x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }
                }
            }
        }
    }
}
