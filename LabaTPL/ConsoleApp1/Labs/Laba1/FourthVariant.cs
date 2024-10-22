using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba1
{
    public class FourthVariant
    {
        ManualResetEvent doneEvent1 = new ManualResetEvent(false);
        ManualResetEvent doneEvent2 = new ManualResetEvent(false);
        ManualResetEvent doneEvent3 = new ManualResetEvent(false);
        ManualResetEvent doneEvent4 = new ManualResetEvent(false);
        ManualResetEvent doneEvent5 = new ManualResetEvent(false);
        ManualResetEvent doneEvent6 = new ManualResetEvent(false);
        ManualResetEvent doneEvent7 = new ManualResetEvent(false);
        ManualResetEvent doneEvent8 = new ManualResetEvent(false);
        ManualResetEvent doneEvent9 = new ManualResetEvent(false);
        ManualResetEvent doneEvent10 = new ManualResetEvent(false);
        ManualResetEvent doneEvent11 = new ManualResetEvent(false);
        ManualResetEvent doneEvent12 = new ManualResetEvent(false);
        ManualResetEvent doneEvent13 = new ManualResetEvent(false);
        ManualResetEvent doneEvent14 = new ManualResetEvent(false);
        ManualResetEvent doneEvent15 = new ManualResetEvent(false);
        public FourthVariant()
        {
            Console.Clear();
            DateTime t1 = DateTime.Now;

            // Используем пул потоков для запуска потоков
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'A', doneEvent1 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'B', doneEvent2 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'C', doneEvent3 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'D', doneEvent4 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'E', doneEvent5 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'F', doneEvent6 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'G', doneEvent7 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'H', doneEvent8 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'I', doneEvent9 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'J', doneEvent10 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'K', doneEvent11 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'L', doneEvent12 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'M', doneEvent13 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'N', doneEvent14 });
            ThreadPool.QueueUserWorkItem(Calculate.PerformCalculations, new object[] { 'O', doneEvent15 });

            // Ожидаем завершения работы потоков
            WaitHandle.WaitAll(new WaitHandle[] { doneEvent1, doneEvent2, doneEvent3, doneEvent4, doneEvent5, doneEvent6, doneEvent7, doneEvent8, doneEvent9, doneEvent10, doneEvent11, doneEvent12, doneEvent13, doneEvent14, doneEvent15 });

            // Конец времени выполнения программы
            DateTime t2 = DateTime.Now;

            // Вывод общего времени выполнения
            Console.WriteLine("Execution Time for all threads in ThreadPool: " + (t2 - t1));
        }
        

    }
}
