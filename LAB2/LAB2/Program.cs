using System;

namespace ConsoleApplication
{
    class Program
    {



        public static int BinarySearch(int[] array, int value)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (value <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (right == -1)
                return -10;
            if (array[right] == value)
                return right;
            return -1;
        }



        static void Main(string[] args)
        {
            TestOneNumbersOfTheFive();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatedNumbers();
            TestEmptyArray();
            TestBigArray();
            Console.ReadKey();
        }



        private static void TestOneNumbersOfTheFive()
        {
            //Тестирование поиска одного элемента в массиве из 5 элементов
            int[] fiveNumbers = new[] { 1, 2, 3, 4, 5 };
            if (BinarySearch(fiveNumbers, 2) != 1)
                Console.WriteLine("! Поиск не нашёл число 2 среди чисел {1, 2, 3, 4, 5}");
            else
                Console.WriteLine("Поиск одного элемента в массиве из 5 элементов работает корректно");
        }



        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }



        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента
            int[] elements = new[] { 2, 4, 7, 9, 123, 397 };
            if (BinarySearch(elements, 567) >= 0)
                Console.WriteLine("! Поиск нашёл число 567 среди чисел { 2, 4, 7, 9, 123, 397}");
            else
                Console.WriteLine("Поиск отсутствующего элемента работает корректно");
        }


        private static void TestRepeatedNumbers()
        {
            //Тестирование поиска элемента, повторяющегося несколько раз
            int[] repeatedNumbers = new[] { 1, 2, 2, 3, 4, 5, 6 };
            if (BinarySearch(repeatedNumbers, 2) == -1)
                Console.WriteLine("! Поиск не нашёл число 2 среди чисел { 1, 2, 2, 3, 4, 5}");
            else
                Console.WriteLine("Поиск элемента, повторяющегося несколько раз, работает корректно");
        }



        private static void TestEmptyArray()
        {
            //Тестирование поиска в пустом массиве (содержащем 0 элементов)
            int[] emptyArray = new int[0];
            if (BinarySearch(emptyArray, 2) != -10)
                Console.WriteLine("! Поиск нашёл число 2 в пустом массиве");
            else
                Console.WriteLine("Поиск в пустом массиве (содержащем 0 элементов) работает корректно");
        }



        private static void TestBigArray()
        {
            //Тестирование поиска в массиве из 100001 элементов
            int[] bigArray = new int[100001];
            Array.Sort(bigArray);
            Random rand = new Random();
            for (int y = 0; y < 100001; y++)
            {
                bigArray[y] = rand.Next(1, 1000);
            }
            bigArray[100000] = 1000;
            Array.Sort(bigArray);
            int findIndex = BinarySearch(bigArray, 1000);
            if (bigArray[findIndex] != 1000)
                Console.WriteLine("! Поиск не нашёл число 1000 в массиве из 100001 элементов");
            else
                Console.WriteLine("Поиск массиве из 100001 элементов работает корректно");
        }




    }
}

