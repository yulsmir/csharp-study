using System;
using _003_ClassRoom.Classes;
using _003_ClassRoom.Classes.Pupils;

namespace _003_ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil("Ivan", 5, 4);
            Pupil pupil2 = new Pupil("Yuri", 3, 4);
            Pupil pupil3 = new Pupil("Olga", 5, 3);
            Pupil pupil4 = new Pupil("Faruh", 3, 5);

            ClassRoom classRoom = new ClassRoom("1-A", pupil1, pupil2, pupil3, pupil4);

            Console.ReadKey();
        }
    }
}
