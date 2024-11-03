using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba2
{
    /// <summary>
    /// Код усложненной многопоточной обработки
    /// </summary>
    public class FourthVariant
    {
        public FourthVariant()
        {
            int N = 100000; // Размер вектора
            int M = 14;    // Количество потоков
            int K = 100;  // Уровень сложности (чем больше K, тем сложнее вычисления)
            double[] a = new double[N];
            double[] b = new double[N];

            // Инициализация массива a случайными значениями
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = rand.NextDouble() * 100;
            }

            // Многопоточная усложненная обработка
            DateTime t1 = DateTime.Now;

            Parallel.For(0, M, threadIndex =>
            {
                int from = threadIndex * N / M;
                int to = (threadIndex + 1) * N / M;

                for (int i = from; i < to; i++)
                {
                    for (int j = 0; j < K; j++)
                    {
                        b[i] += Math.Pow(a[i], 1.789);
                    }
                }
            });

            DateTime t2 = DateTime.Now;

            // Время выполнения
            var t = (t2 - t1).TotalMilliseconds;
            // Время выполнения
            Console.WriteLine($"Время: {t} мс");

        }
    }
}
