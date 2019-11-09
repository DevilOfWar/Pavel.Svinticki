using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EpamTask01dll
{
    /// <summary>
    /// static class GCMs for taking GCM by differense ways 
    /// </summary>
    public static class GCMs
    {
        /// <summary>
        /// Taking GCM of two numbers by Eyklid algorithm
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
        /// <summary>
        /// Taking GCM of difference count of numbers by Eyklid algorithm
        /// </summary>
        /// <param name="array">Array of numbers</param>
        /// <returns></returns>
        public static int GCM(params int[] array)
        {
            if (array.Length <= 1)
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
        /// <summary>
        /// Taking GCM of two numbers by Binary Eyklid algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int BinaryGCM(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            else if (a == 1 || b == 1)
            {
                return 1;
            }
            else if (a % 2 == 0 && b % 2 == 0)
            {
                return 2 * GCMs.BinaryGCM(a / 2, b / 2);
            }
            else if (a % 2 == 1 && b % 2 == 0)
            {
                return GCMs.BinaryGCM(a, b / 2);
            }
            else if (a % 2 == 0 && b % 2 == 1)
            {
                return GCMs.BinaryGCM(a / 2, b);
            }
            else
            {
                return GCMs.BinaryGCM((Math.Max(a, b) - Math.Min(a, b)) / 2, Math.Min(a, b));
            }
        }
        /// <summary>
        /// Taking GCM of parametr's array. Return GCM and time.
        /// </summary>
        /// <param name="compliteTime">Time of complitting</param>
        /// <param name="array">Array of numbers</param>
        /// <returns></returns>
        public static int GCMTime(out Stopwatch compliteTime, params int[] array)
        {
            compliteTime = new Stopwatch();
            compliteTime.Start();
            int result = GCMs.GCM(array);
            compliteTime.Stop();
            return result;
        }
        /// <summary>
        /// Taking GCM by binary Evklidov algorithm. Return GCM and time.
        /// </summary>
        /// <param name="compliteTime">Time of complitting</param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns></returns>
        public static int BinaryGCMTime(out Stopwatch compliteTime, int a, int b)
        {
            compliteTime = new Stopwatch();
            compliteTime.Start();
            int result = GCMs.BinaryGCM(a, b);
            compliteTime.Stop();
            return result;
        }
    }
}
