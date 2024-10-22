using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba2
{
    /// <summary>
    /// Код последовательной обработки
    /// </summary>
    public class FirstVariant
    {
        public FirstVariant()
        {
            int N = 100000; // Размер вектора
            double[] a = new double[N];
            double[] b = new double[N];

            // Инициализация массива a случайными значениями
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = rand.NextDouble() * 100;
            }

            // Последовательная обработка (возведение в степень)
            DateTime t1 = DateTime.Now;
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = Math.Pow(a[i], 1.789);
            }
            DateTime t2 = DateTime.Now;

            var t = (t2 - t1).TotalMilliseconds;
            // Время выполнения
            Console.WriteLine($"Последовательное выполнение: {t} мс");

        }
    }
}
