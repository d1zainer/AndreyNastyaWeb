using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba2
{
    /// <summary>
    /// Код многопоточной обработки
    /// </summary>
    public class ThirdVariant
    {
        public ThirdVariant()
        {
            int N = 100000; // Размер вектора
            int M = 14;    // Количество потоков
            double[] a = new double[N];
            double[] b = new double[N];

            // Инициализация массива a случайными значениями
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = rand.NextDouble() * 100;
            }

            // Многопоточная обработка
            DateTime t1 = DateTime.Now;

            Parallel.For(0, M, threadIndex =>
            {
                int from = threadIndex * N / M;
                int to = (threadIndex + 1) * N / M;

                for (int i = from; i < to; i++)
                {
                    b[i] = Math.Pow(a[i], 1.789);
                }
            });

            DateTime t2 = DateTime.Now;

            var t = (t2 - t1).TotalMilliseconds;
            // Время выполнения
            Console.WriteLine($"Последовательное выполнение: {t} мс");
        }

    }
}

