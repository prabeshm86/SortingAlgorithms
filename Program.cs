using System;
using System.Linq;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Int32.Parse);
            Sorter sorter = null;
            switch (args[0].Trim())
            {
                case "merge":
                    sorter = new MergeSort();
                    break;
                case "insertion":
                    sorter = new InsertionSort();
                    break;
                case "bubble":
                    sorter = new BubbleSort();
                    break;
            }
            Console.WriteLine(Array.ConvertAll(sorter.Sort(arr), x => x.ToString()).Aggregate((a, b) => a + " " + b));
        }

    }
}
