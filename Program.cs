using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лабораторная работа №1: Вычисление площади прямоугольника
            Console.WriteLine("=== Лабораторная работа №1 ===");
            Console.Write("Введите длину: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            double area = a * b;
            Console.WriteLine($"Площадь прямоугольника: {area}");
        }
    }
}
