using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class MergeSort : Sorter
    {
        public int[] Sort(int[] input)
        {
           return Sort(0, input.Length - 1, input);
        }

        int[] Sort(int start, int end, int[] arr)
        {
            if (start == end) return new int[] { arr[start] };
            int mid = start + ((end - start) / 2);
            var left = Sort(start, mid, arr);
            var right = Sort(mid + 1, end, arr);
            return Merge(left, right);

        }

        int[] Merge(int[] left, int[] right)
        {
            var totalLen = left.Length + right.Length;
            int[] mergedArr = new int[totalLen];

            int leftStart = 0; int rightStart = 0;
            for (int i = 0; i < totalLen; i++)
            {
                if (rightStart > right.Length - 1)
                {
                    mergedArr[i] = left[leftStart];
                    leftStart++;
                }
                else if (leftStart > left.Length - 1)
                {
                    mergedArr[i] = right[rightStart];
                    rightStart++;
                }
                else if (left[leftStart] <= right[rightStart])
                {
                    mergedArr[i] = left[leftStart];
                    leftStart++;
                }
                else
                {
                    mergedArr[i] = right[rightStart];
                    rightStart++;
                }

            }
            return mergedArr;
        }

    }
}
