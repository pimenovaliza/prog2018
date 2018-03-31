using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solve;

namespace Solver.Tests
{

    [TestClass]
    public class Tests
    {
        public static Random random = new Random();
        [TestMethod]
        public void ThreeElements() //Сортировка массива из трёх элементов.
        {
            var array = GenerateArray.Generate(3);
            Solve.Sort(array, 0, array.Length - 1);
            //После сортировки второй элемент больше первого, третий больше второго
            Assert.IsTrue(array[1] >= array[0], "Второй элемент больше (или равен) первого");
            Assert.IsTrue(array[2] >= array[1], "Тетий элемент больше (или равен) второго");
        }

        [TestMethod]
        public void OneHundredIdenticalElements() //Сортировка массива из 100 одинаковых чисел
        {
            var array = new int[100];
            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = 10;
            }
            Solve.Sort(array, 0, array.Length - 1);
        }


        [TestMethod]
        public void OneThousandDifferentElements() //Сортировка массива из 1000 разных чисел
        {
            var array = GenerateArray.Generate(100);
            Solve.Sort(array, 0, array.Length - 1);
            //Проверить что 10 случайных пар элементов массива после сортировки упорядочены (из пары больший тот, чей индекс больше)
            for (var i = 0; i < 10; i++)
            {
                int firstIndex = random.Next(0, (array.Length - 1) / 2);
                int secondIndex = random.Next((array.Length - 1) / 2, array.Length - 1);
                Assert.IsTrue(array[firstIndex] <= array[secondIndex], "из пары больший тот, чей индекс больше");
            }

        }


        [TestMethod]
        public void EmptyArray() //Сортировка пустого массива
        {
            var array = new int[0];
            Solve.Sort(array, 0, array.Length - 1);
        }


        [TestMethod]
        public void BigArray() //Сортировка массива из трёх элементов.
        {
            var array = GenerateArray.Generate(5000000);
            Solve.Sort(array, 0, array.Length - 1);
        }
    }
}
