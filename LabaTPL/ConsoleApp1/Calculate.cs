using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Labs.Laba1
{
    public static class  Calculate
    {
        // Метод для выполнения вычислений
        public static void PerformCalculations(object state)
        {
            // Получаем переданные параметры (литера и событие)
            object[] array = (object[])state;
            char letter = (char)array[0];
            ManualResetEvent doneEvent = (ManualResetEvent)array[1];

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
            Console.WriteLine($"{letter}: " + x.ToString());

            // Сообщаем о завершении потока
            doneEvent.Set();
        }

        // Статическая процедура, выполняющая вычисления
        public static void PerformCalculations(char letter)
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
            Console.WriteLine($"{letter}: " + x.ToString());
        }
    }
}
