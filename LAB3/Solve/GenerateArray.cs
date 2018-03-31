using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve
{
    public class GenerateArray
    {
        public static Random random = new Random();
        public static int[] Generate(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            return array;
        }
    }
}
