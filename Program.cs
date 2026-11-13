using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лабораторная работа №2: Проверка числа на четность
            Console.WriteLine("=== Лабораторная работа №2 ===");
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} — четное.");
            }
            else
            {
                Console.WriteLine($"Число {number} — нечетное.");
            }
        }
    }
}
