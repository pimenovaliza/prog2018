using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solve;

namespace LAB3
{
    class Program
    {

        public static void Main()
        {
            var array = GenerateArray.Generate(10);
            Sort.QuickSort(array, 0, array.Length - 1);
            foreach (var e in array)
                Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}

