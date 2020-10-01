using System;
using _003_ClassRoom.Classes;
using _003_ClassRoom.Classes.Pupils;

namespace _003_ClassRoom
{
    class Program
    {
        static void Main()
        {
            
            Pupil pupil1 = new Pupil("Oscar Ivanov", 5, 5);
            Pupil pupil2 = new Pupil("John Petroff", 4, 5);
            Pupil pupil3 = new Pupil("Mary Pupkina", 3, 4);
            Pupil pupil4 = new Pupil("Ivanka Tutsi", 2, 5);

            ClassRoom classRoom = new ClassRoom("1-A", pupil1, pupil2, pupil3, pupil4);
            Console.ReadKey();
        }
    }
}
