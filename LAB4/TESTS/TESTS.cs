using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB4;

namespace TESTS
{
    [TestClass]
    public class TESTS
    {
        [TestMethod]
        public void ThreeElements()
        {
            var hashTableOfThreeElements = new LAB4.HashTable(3);

            hashTableOfThreeElements.PutPair("5", "Five");
            hashTableOfThreeElements.PutPair("7", "Seven");
            hashTableOfThreeElements.PutPair("33", "Thirty three");

            Assert.AreEqual(hashTableOfThreeElements.GetValueByKey("5"), "Five");
            Assert.AreEqual(hashTableOfThreeElements.GetValueByKey("7"), "Seven");
            Assert.AreEqual(hashTableOfThreeElements.GetValueByKey("33"), "Thirty three");
        }

        [TestMethod]
        public void TwoEquialsElements()
        {
            var hashTableOfTwoEquialsElementsht = new LAB4.HashTable(5);

            hashTableOfTwoEquialsElementsht.PutPair("5", "Пять");
            hashTableOfTwoEquialsElementsht.PutPair("5", "Five");

            Assert.AreEqual(hashTableOfTwoEquialsElementsht.GetValueByKey("5"), "Five");
        }

        [TestMethod]
        public void BigElementsTest()
        {
            var bigHashTable = new LAB4.HashTable(10000);

            for (int i = 0; i < 10000; i++)
            {
                bigHashTable.PutPair(i, i + "!");
            }

            Assert.AreEqual(bigHashTable.GetValueByKey(55), "55!");
        }

        [TestMethod]
        public void SearchForMissingElements()
        {
            var bigHashTable = new LAB4.HashTable(10000);

            for (int i = 0; i < 10000; i++)
            {
                bigHashTable.PutPair(i, i + "!");
            }

            for (int i = 10000; i < 11000; i++)
            {
                Assert.AreEqual(bigHashTable.GetValueByKey(i), null);
            }
        }
    }
}

