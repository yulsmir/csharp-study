using System;

namespace MusicalScale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Beep(523, 1500); // До
            Console.Beep(587, 500); // Ре
            Console.Beep(659, 500); // Ми
            Console.Beep(698, 500); // Фа
            Console.Beep(784, 500); // Соль
            Console.Beep(880, 500); // Ля
            Console.Beep(988, 500); // Си
        }
    }
}
