using System;
using System.Linq;
using static System.Math;

namespace Lab4Array
{
    public static class Variant14
    {
        public static int[] Task1(in int[] array)
        {
            var minValue = array.Min();
            var minValueIndex = Array.IndexOf(array, minValue);

            return [minValue, minValueIndex];
        }

        public static int[] Task2(in int[] arrayV)
        {
            var arrayX = new int[arrayV.Length];

            for (var i = 0; i < arrayX.Length; i++)
            {
                arrayX[i] = -4 * arrayV[i];  
            }

            return arrayX;
        }

        public static int[] Task3(in int[] arrayX, in int[] arrayV)
        {
            var count = 0;
            var product = 1;

            for (var i = 0; i < arrayX.Length && i < arrayV.Length; i++)
            {
                if (Abs(arrayX[i]) > arrayV[i])
                {
                    product *= arrayX[i];
                    count++;
                }
            }

            if (count == 0)
            {
                product = 0;
            }

            return [product, count];
        }
    }
}
