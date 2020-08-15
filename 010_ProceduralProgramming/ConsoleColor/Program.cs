using System;

namespace ConsoleColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;   // Устанавливаем цвет букв
            Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона

            Console.WriteLine("Hello world!");
            Console.WriteLine("Hello friends!");

            Console.ResetColor();  // Сбрасываем настройки цвета букв и фона
            //Console.ForegroundColor = ConsoleColor.Gray;  // Устанавливаем цвет букв
            //Console.BackgroundColor = ConsoleColor.Black; // Устанавливаем цвет фона

            Console.WriteLine("Goodbye!");

            // Delay
            Console.ReadKey();
        }
    }
}
