using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba2
{
    public class SixthVariant
    {
        public SixthVariant()
        {

            int N = 10000; // Размер вектора
            int M = 14;    // Количество потоков
            double[] a = new double[N];
            double[] b = new double[N];

            // Инициализация массива a случайными значениями
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                a[i] = rand.NextDouble() * 100;
            }

            // Круговое разделение элементов между потоками
            DateTime t1 = DateTime.Now;

            Parallel.For(0, M, threadIndex =>
            {
                for (int i = threadIndex; i < N; i += M)
                {
                    for (int j = 0; j < i; j++)  // Неравномерная сложность
                    {
                        b[i] += Math.Pow(a[i], 1.789);
                    }
                }
            });

            DateTime t2 = DateTime.Now;

            var t = (t2 - t1).TotalMilliseconds;
            // Время выполнения
            Console.WriteLine($"Последовательное выполнение: {t} мс");

        }
    }
}
