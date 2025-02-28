using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8B2
{
    public class Calculator
    {
        public static int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array can't be null or empty");
            }
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        public static int FindMin(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array can't be null or empty");
            }
            int min = array[0];
            foreach (int num in array)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
