using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba1
{
    public class SecondVariant
    {
        public SecondVariant()
        {
            Console.Clear();
            // Старт времени выполнения программы
            DateTime t1 = DateTime.Now;

            // Создаем первый поток (литера 'A')
            Thread thread1 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("A: " + x.ToString());
            });

            // Создаем второй поток (литера 'B')
            Thread thread2 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("B: " + x.ToString());
            });

            // Создаем третий поток (литера 'C')
            Thread thread3 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("C: " + x.ToString());
            });

            // Создаем четвертый поток (литера 'D')
            Thread thread4 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("D: " + x.ToString());
            });

            // Создаем пятый поток (литера 'E')
            Thread thread5 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("E: " + x.ToString());
            });

            // Создаем шестой поток (литера 'F')
            Thread thread6 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("F: " + x.ToString());
            });

            // Создаем седьмой поток (литера 'G')
            Thread thread7 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("G: " + x.ToString());
            });

            // Создаем восьмой поток (литера 'H')
            Thread thread8 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("H: " + x.ToString());
            });

            // Создаем девятый поток (литера 'I')
            Thread thread9 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("I: " + x.ToString());
            });

            // Создаем десятый поток (литера 'J')
            Thread thread10 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("J: " + x.ToString());
            });

            // Создаем одиннадцатый поток (литера 'K')
            Thread thread11 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("K: " + x.ToString());
            });

            // Создаем двенадцатый поток (литера 'L')
            Thread thread12 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("L: " + x.ToString());
            });

            // Создаем тринадцатый поток (литера 'M')
            Thread thread13 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("M: " + x.ToString());
            });

            // Создаем четырнадцатый поток (литера 'N')
            Thread thread14 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("N: " + x.ToString());
            });

            // Создаем пятнадцатый поток (литера 'O')
            Thread thread15 = new Thread(() =>
            {
                double x = 12345.6789;
                for (int i = 0; i < 10000; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        x = Math.Sqrt(x);
                        x = x + 0.000000001;
                        x = Math.Pow(x, 2);
                    }
                }
                Console.WriteLine("O: " + x.ToString());
            });

            // Запуск потоков
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();
            thread9.Start();
            thread10.Start();
            thread11.Start();
            thread12.Start();
            thread13.Start();
            thread14.Start();
            thread15.Start();

            // Ожидание завершения работы потоков
            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            thread5.Join();
            thread6.Join();
            thread7.Join();
            thread8.Join();
            thread9.Join();
            thread10.Join();
            thread11.Join();
            thread12.Join();
            thread13.Join();
            thread14.Join();
            thread15.Join();

            // Конец времени выполнения программы
            DateTime t2 = DateTime.Now;

            // Вывод общего времени выполнения
            Console.WriteLine("Execution Time for all threads: " + (t2 - t1));

        }
    }
}
