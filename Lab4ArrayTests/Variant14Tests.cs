using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Lab4Array.Variant14;

namespace Lab4ArrayTests
{
    [TestClass]
    public class Variant14Tests
    {
        [TestMethod]
        public void Task1_Enter_5_20_3_6_Return_3_2()
        {
            int[] array = [5, 20, 3, 6];
            int[] expected = [3, 2];

            var actual = Task1(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_45_20_30_6_Return_6_3()
        {
            int[] array = [45, 20, 30, 6];
            int[] expected = [6, 3];

            var actual = Task1(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_5_20_30_6_Return_5_0()
        {
            int[] array = [5, 20, 30, 6];
            int[] expected = [5, 0];

            var actual = Task1(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_45_2_30_6_Return_2_1()
        {
            int[] array = [45, 2, 30, 6];
            int[] expected = [2, 1];

            var actual = Task1(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_45_20_30_6_4_Return_4_4()
        {
            int[] array = [45, 20, 30, 6, 4];
            int[] expected = [4, 4];

            var actual = Task1(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_1_2_5_Return_Minus4_Minus8_Minus20()
        {
            int[] array = [1, 2, 5];
            int[] expected = [-4, -8, -20];

            var actual = Task2(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_2_3_5_Return_Minus8_Minus12_Minus20()
        {
            int[] array = [2, 3, 5];
            int[] expected = [-8, -12, -20];

            var actual = Task2(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_1_6_4_Return_Minus4_Minus24_Minus16()
        {
            int[] array = [1, 6, 4];
            int[] expected = [-4, -24, -16];

            var actual = Task2(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_7_2_8_Return_Minus4_Minus8_Minus20()
        {
            int[] array = [7, 2, 8];
            int[] expected = [-28, -8, -32];

            var actual = Task2(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_10_20_50_Return_Minus40_Minus80_Minus200()
        {
            int[] array = [10, 20, 50];
            int[] expected = [-40, -80, -200];

            var actual = Task2(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_test1()
        {
            int[] arrayV = [1, 2, 50];
            int[] arrayX = [-40, 20, 50];
            int[] expected = [800, 2];

            var actual = Task3(arrayX, arrayV);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_test2()
        {
            int[] arrayV = [56, 2, 50];
            int[] arrayX = [-40, 20, 50];
            int[] expected = [20, 1];

            var actual = Task3(arrayX, arrayV);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_test3()
        {
            int[] arrayV = [56, 20, 50];
            int[] arrayX = [-40, 20, 50];
            int[] expected = [0, 0];

            var actual = Task3(arrayX, arrayV);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_test4()
        {
            int[] arrayV = [6, 0, 5];
            int[] arrayX = [-40, 20, 50];
            int[] expected = [-40000, 3];

            var actual = Task3(arrayX, arrayV);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_test5()
        {
            int[] arrayV = [566, 2, 50];
            int[] arrayX = [-40, 20, 50];
            int[] expected = [20, 1];

            var actual = Task3(arrayX, arrayV);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
