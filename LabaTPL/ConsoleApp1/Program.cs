using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Консольное меню:");
                Console.WriteLine("1. Первая лабораторная работа");
                Console.WriteLine("2. Вторая лабораторная работа");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        FirstLabMenu();
                        break;
                    case "2":
                        SecondLabMenu();
                        break;
                    case "3":
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
                Console.ReadKey();
            }
        }


        static void FirstLabMenu()
        {
            Console.Clear();
            Console.WriteLine("Первая лабораторная работа - Варианты:");
            Console.WriteLine("1. Вариант 1 - Последовательная обработка");
            Console.WriteLine("2. Вариант 2 - Многопоточная, инициализация с помощью лямбда-выражений");
            Console.WriteLine("3. Вариант 3 - Многопоточная, инициализация с помощью статического метода");
            Console.WriteLine("4. Вариант 4 - Многопоточный с использованием пула потоков");
            Console.WriteLine("5. Вариант 5 - Cтатистического метода с использованием установки приоритетов");
            Console.Write("Выберите вариант: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Labs.Laba1.FirstVariant first = new Labs.Laba1.FirstVariant();
                    break;
                case "2":
                    Labs.Laba1.SecondVariant second = new Labs.Laba1.SecondVariant();
                    break;
                case "3":
                    Labs.Laba1.ThirdVariant third = new Labs.Laba1.ThirdVariant();
                    break;
                case "4":
                    Labs.Laba1.FourthVariant fourth = new Labs.Laba1.FourthVariant();
                    break;
                case "5":
                    Labs.Laba1.FifthVariant fifth = new Labs.Laba1.FifthVariant();    
                    break;
                default:
                    Console.WriteLine("Неверный выбор варианта.");
                    break;
            }
        }

        static void SecondLabMenu()
        {
            Console.Clear();
            Console.WriteLine("Первая лабораторная работа - Варианты:");
            Console.WriteLine("1. Вариант 1 - Последовательная обработка");
            Console.WriteLine("2. Вариант 2 - Усложненной последовательной обработки");
            Console.WriteLine("3. Вариант 3 - Многопоточной обработкиа");
            Console.WriteLine("4. Вариант 4 - Усложненной многопоточной обработки");
            Console.WriteLine("5. Вариант 5 - Разделения по диапазону");
            Console.WriteLine("5. Вариант 6 - Параллелизма при круговом разделении");
            Console.Write("Выберите вариант: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Labs.Laba2.FirstVariant first = new Labs.Laba2.FirstVariant();
                    break;
                case "2":
                    Labs.Laba2.SecondVariant second = new Labs.Laba2.SecondVariant();
                    break;
                case "3":
                    Labs.Laba2.ThirdVariant third = new Labs.Laba2.ThirdVariant();
                    break;
                case "4":
                    Labs.Laba2.FourthVariant fourth = new Labs.Laba2.FourthVariant();
                    break;
                case "5":
                    Labs.Laba2.FifthVariant fifth = new Labs.Laba2.FifthVariant();
                    break;
                default:
                    Console.WriteLine("Неверный выбор варианта.");
                    break;
            }
        }


    }
}

