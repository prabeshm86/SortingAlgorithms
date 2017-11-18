using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class InsertionSort : Sorter
    {
        public int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var key = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[key])
                    {
                        var temp = arr[key];
                        arr[key] = arr[j];
                        arr[j] = temp;
                        key = j;
                    }
                }
            }

            return arr;
        }
    }
}
