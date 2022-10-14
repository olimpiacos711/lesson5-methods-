using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Program
    {
        static public int MaxValue(int[] maxArr)
        {
            int max = maxArr.Max();
            return max;
        }

        static public int MinValue(int[] maxArr)
        {
            int min = maxArr.Min();
            return min;
        }

        static public int MaxValue(int x, int y, int z)
        {
            int max1 = Math.Max(x, y);
            int max2 = Math.Max(max1, z);
            return max2;
            
        }

        static public int MinValue(int x, int y, int z)
        {
            int min1 = Math.Min(x, y);
            int min2 = Math.Min(min1, z);
            return min2;

        }

        static bool TrySumIfOdd (int a, int b, out bool result)
        {
            if ( (a + b) % 2 != 0)
                result = true;
            else 
                result = false;
            return result;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int maxNumber = MaxValue(arr);
            Console.WriteLine("Max array value: " + maxNumber);

            int minNumber = MinValue(arr);
            Console.WriteLine("Min array value: " + minNumber);

            int max = MaxValue(3, 4, 5);
            Console.WriteLine("Max value is: " + max);

            int min = MinValue(3, 4, 5);
            Console.WriteLine("Min value is: " + min);

            bool res = TrySumIfOdd(2, 3, out res);
            Console.WriteLine(res);
        }
    }
}
