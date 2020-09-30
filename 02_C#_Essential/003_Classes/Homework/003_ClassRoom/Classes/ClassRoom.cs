using System;
using System.Collections.Generic;
using System.Text;
using _003_ClassRoom.Classes.Pupils;

namespace _003_ClassRoom.Classes
{
    class ClassRoom
    {
        public string name;
        public ClassRoom(string name, Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Classroom: {0}", name);
            Console.BackgroundColor = ConsoleColor.Black;
            pupil1.PrintInfo();
            pupil2.PrintInfo();
            pupil3.PrintInfo();
            pupil4.PrintInfo();
        }
    }
}
