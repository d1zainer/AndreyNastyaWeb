using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba1
{
    public class ThirdVariant
    {
        public ThirdVariant()
        {
            Console.Clear();
            DateTime t1 = DateTime.Now;
            // Создаем первый поток, передавая в него статическую процедуру и литеру 'A'
            Thread thread1 = new Thread(() => Calculate.PerformCalculations('A'));

            // Создаем второй поток, передавая в него статическую процедуру и литеру 'B'
            Thread thread2 = new Thread(() => Calculate.PerformCalculations('B'));

            // Создаем третий поток, передавая в него статическую процедуру и литеру 'C'
            Thread thread3 = new Thread(() => Calculate.PerformCalculations('C'));

            // Создаем четвертый поток, передавая в него статическую процедуру и литеру 'D'
            Thread thread4 = new Thread(() => Calculate.PerformCalculations('D'));

            // Создаем пятый поток, передавая в него статическую процедуру и литеру 'E'
            Thread thread5 = new Thread(() => Calculate.PerformCalculations('E'));

            // Создаем шестой поток, передавая в него статическую процедуру и литеру 'F'
            Thread thread6 = new Thread(() => Calculate.PerformCalculations('F'));

            // Создаем седьмой поток, передавая в него статическую процедуру и литеру 'G'
            Thread thread7 = new Thread(() => Calculate.PerformCalculations('G'));

            // Создаем восьмой поток, передавая в него статическую процедуру и литеру 'H'
            Thread thread8 = new Thread(() => Calculate.PerformCalculations('H'));

            // Создаем девятый поток, передавая в него статическую процедуру и литеру 'I'
            Thread thread9 = new Thread(() => Calculate.PerformCalculations('I'));

            // Создаем десятый поток, передавая в него статическую процедуру и литеру 'J'
            Thread thread10 = new Thread(() => Calculate.PerformCalculations('J'));

            // Создаем одиннадцатый поток, передавая в него статическую процедуру и литеру 'K'
            Thread thread11 = new Thread(() => Calculate.PerformCalculations('K'));

            // Создаем двенадцатый поток, передавая в него статическую процедуру и литеру 'L'
            Thread thread12 = new Thread(() => Calculate.PerformCalculations('L'));

            // Создаем тринадцатый поток, передавая в него статическую процедуру и литеру 'M'
            Thread thread13 = new Thread(() => Calculate.PerformCalculations('M'));

            // Создаем четырнадцатый поток, передавая в него статическую процедуру и литеру 'N'
            Thread thread14 = new Thread(() => Calculate.PerformCalculations('N'));

            // Создаем пятнадцатый поток, передавая в него статическую процедуру и литеру 'O'
            Thread thread15 = new Thread(() => Calculate.PerformCalculations('O'));

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
            Console.WriteLine("Execution Time for all threads with static method: " + (t2 - t1));
        }

        

    }
}

