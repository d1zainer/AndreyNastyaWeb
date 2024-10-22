using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba1
{
    public class FifthVariant
    {
        public FifthVariant()
        {
            Console.Clear();
            DateTime t1 = DateTime.Now;

            // Создаем и присваиваем приоритеты для 15 потоков
            Thread thread1 = new Thread(() => Calculate.PerformCalculations('A'));
            thread1.Priority = ThreadPriority.Lowest;

            Thread thread2 = new Thread(() => Calculate.PerformCalculations('B'));
            thread2.Priority = ThreadPriority.BelowNormal;

            Thread thread3 = new Thread(() => Calculate.PerformCalculations('C'));
            thread3.Priority = ThreadPriority.Normal;

            Thread thread4 = new Thread(() => Calculate.PerformCalculations('D'));
            thread4.Priority = ThreadPriority.AboveNormal;

            Thread thread5 = new Thread(() => Calculate.PerformCalculations('E'));
            thread5.Priority = ThreadPriority.Highest;

            Thread thread6 = new Thread(() => Calculate.PerformCalculations('F'));
            thread6.Priority = ThreadPriority.Lowest;

            Thread thread7 = new Thread(() => Calculate.PerformCalculations('G'));
            thread7.Priority = ThreadPriority.BelowNormal;

            Thread thread8 = new Thread(() => Calculate.PerformCalculations('H'));
            thread8.Priority = ThreadPriority.Normal;

            Thread thread9 = new Thread(() => Calculate.PerformCalculations('I'));
            thread9.Priority = ThreadPriority.AboveNormal;

            Thread thread10 = new Thread(() => Calculate.PerformCalculations('J'));
            thread10.Priority = ThreadPriority.Highest;

            Thread thread11 = new Thread(() => Calculate.PerformCalculations('K'));
            thread11.Priority = ThreadPriority.Lowest;

            Thread thread12 = new Thread(() => Calculate.PerformCalculations('L'));
            thread12.Priority = ThreadPriority.BelowNormal;

            Thread thread13 = new Thread(() => Calculate.PerformCalculations('M'));
            thread13.Priority = ThreadPriority.Normal;

            Thread thread14 = new Thread(() => Calculate.PerformCalculations('N'));
            thread14.Priority = ThreadPriority.AboveNormal;

            Thread thread15 = new Thread(() => Calculate.PerformCalculations('O'));
            thread15.Priority = ThreadPriority.Highest;

            // Запуск всех потоков
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

            // Ожидание завершения работы всех потоков
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
            Console.WriteLine("Execution Time for all threads with different priorities: " + (t2 - t1));
        }

        // Статическая процедура, выполняющая вычисления

    }
}

