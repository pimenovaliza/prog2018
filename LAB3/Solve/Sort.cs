using System;
using System.Text;
using System.Threading.Tasks;

namespace Solve
{
    public class Sort
    {
        public static void QuickSort(int[] array, int start, int end)
        {
            if (end == -1)
            {
                Console.WriteLine("Error");
                return;
            }
            if (end == start)
                return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    Sort.Switch(array, i, storeIndex);
                    storeIndex++;
                }
            Sort.Switch(array, storeIndex, end);
            if (storeIndex > start) QuickSort(array, start, storeIndex - 1);
            if (storeIndex < end) QuickSort(array, storeIndex + 1, end);
        }



        static void Switch(int[] array, int firstIndex, int secondIndex)
        {
            var t = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = t;
        }
    }
}
