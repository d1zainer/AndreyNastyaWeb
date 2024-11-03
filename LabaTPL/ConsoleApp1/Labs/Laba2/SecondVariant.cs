using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba2
{
    /// <summary>
    /// Код усложненной последовательной обработки
    /// </summary>
    public class SecondVariant
    {
        public SecondVariant()
        {
            int N = 100000; // Размер вектора
            int K = 100;  // Уровень сложности (чем больше K, тем сложнее вычисления)
            double[] a = new double[N];
            double[] b = new double[N];

            // Инициализация массива a случайными значениями
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = rand.NextDouble() * 100;
            }

            // Усложненная последовательная обработка
            DateTime t1 = DateTime.Now;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    b[i] += Math.Pow(a[i], 1.789);
                }
            }
            DateTime t2 = DateTime.Now;

            var t = (t2 - t1).TotalMilliseconds;
            // Время выполнения
            Console.WriteLine($"Время: {t} мс");

        }
    }
}
