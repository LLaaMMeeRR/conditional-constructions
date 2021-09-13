using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let`s try!");

            // Задача 2
            /* 
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You r enter: {num}");

                if (10 > num && num > 5)
                {
                    Console.WriteLine($"Число {num} больше 5 и меньше 10");
                }

                else if (5 > num)
                {
                    Console.WriteLine($"Число {num} меньше 5");
                }

                else 
                {
                    Console.WriteLine($"Число {num} больше 10");
                }
            */

            // Задача 3
            /*
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Вы ввели: {i}");

                if (i == 5 | i == 10)
                {
                    Console.WriteLine($" Число {i} либо равно 10, либо равно 5.");
                }

                else
                {
                    Console.WriteLine($" Число {i}, неизвестное число...");
                }
            */

            // Задача 4
            /*
                Console.WriteLine("Введите сумму пополнения:");
                double i = Convert.ToDouble(Console.ReadLine());

                if (i < 101)
                {
                    Console.WriteLine($"Ваш бонус составляет 5% от {i}$");
                    double z;
                    z = i * 0.05;
                    Console.WriteLine($"Ваш бонус составляет: {z}%.");
                    z = i + z;
                    Console.WriteLine($"Сумма пополнения: {z}$.");
                }

                else if (i > 99 && i < 200)
                {
                    Console.WriteLine($"Ваш бонус составляет 7% от {i}$");
                    double z;
                    z = i * 0.07;
                    Console.WriteLine($"Ваш бонус составляет: {z}%.");
                    z = i + z;
                    Console.WriteLine($"Сумма пополнения: {z}$.");
                }
                else
                {
                    Console.WriteLine($"Ваш бонус составляет 10% от {i}$");
                    double z;
                    z = i * 0.1;
                    Console.WriteLine($"Ваш бонус составляет: {z}%.");
                    z = i + z;
                    Console.WriteLine($"Сумма пополнения: {z}$.");
                }
            */

            // Задача 5
            /*
            Console.WriteLine("Меню:");
            Console.WriteLine("");
            Console.WriteLine("Выберите один из пунктов:");
            Console.WriteLine("");
            Console.WriteLine("1 - Сложение.");
            Console.WriteLine("2 - Вычитание.");
            Console.WriteLine("3 - Деление.");
            Console.WriteLine("4 - Умножение.");

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Вы выбрали сложение.");
                    break;

                case "2":
                    Console.WriteLine("Вы выбрали вычитание.");
                    break;

                case "3":
                    Console.WriteLine("Вы выбрали деление.");
                    break;

                case "4":
                    Console.WriteLine("Вы выбрали умножение.");
                    break;

                default:
                    Console.WriteLine($"Данного запроса не существует {selection}");
                    break;

            }
            */
            //Задача 6
            /*

            Console.WriteLine("Введите числа для рассчета:");

            Console.WriteLine("");
            Console.WriteLine("1 число:");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("2 число:");
            int y = Convert.ToInt32(Console.ReadLine());

            int z;

            Console.WriteLine("Меню:");
            Console.WriteLine("");
            Console.WriteLine("Выберите один из пунктов:");
            Console.WriteLine("");
            Console.WriteLine("1 - Сложение.");
            Console.WriteLine("2 - Вычитание.");
            Console.WriteLine("3 - Деление.");
            Console.WriteLine("4 - Умножение.");

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.Write($"{x} + {y} = ");
                    z = x + y;
                    Console.Write(z);
                    break;
                   

                case "2":
                    Console.Write($"{x} - {y} = ");
                    z = x - y;
                    Console.Write(z);
                    break;


                case "3":
                    Console.Write($"{x} / {y} = ");
                    z = x / y;
                    Console.Write(z);
                    break;


                case "4":
                    Console.Write($"{x} * {y} = ");
                    z = x * y;
                    Console.Write(z);
                    break;


                default:
                    Console.WriteLine($"Данного запроса не существует {selection}");
                    break;
            }
            */


        }
    }
}
