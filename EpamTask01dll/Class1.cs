using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask01dll
{
    /// <summary>
    /// static class GCMs for taking GCM by differense ways 
    /// </summary>
    public static class GCMs
    {
        /// <summary>
        /// Taking GCM from two numbers by Eyklid algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GCM(int a, int b)
        {
            while (a != 0 && b !=0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }
        public static int GCM(params int[] array)
        {
            if (array.Length > 1)
            {
                Console.WriteLine("Wrong number of paramets.");
                return 0;
            }
            int result = GCMs.GCM(array[0], array[1]);
            for (int index = 2; index < array.Length && result != 1; index++)
            {
                result = GCMs.GCM(result, array[index]);
            }
            return result;
        }
    }
}
