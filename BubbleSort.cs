using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class BubbleSort : Sorter
    {
        public int[] Sort(int[] input)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var tempJ = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tempJ;
                    }
                }
            }
            return arr;
        }
    }
}
