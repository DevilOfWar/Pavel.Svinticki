using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask01dll
{
    /// <summary>
    /// статический класс GCMs для получения Наибольшего Общего Делителя (НОД, GCM) различными способами 
    /// </summary>
    public static class GCMs
    {
        /// <summary>
        /// Получение НОДа двух чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
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
    }
}
