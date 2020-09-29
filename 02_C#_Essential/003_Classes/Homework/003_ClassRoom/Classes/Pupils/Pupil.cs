using System;
using System.Collections.Generic;
using System.Text;

namespace _003_ClassRoom.Classes.Pupils
{
    class Pupil
    {
        public string name;
        public decimal readScore;
        public decimal writeScore;

        public virtual void Study() 
        {
            decimal studyScore = Math.Round((readScore + writeScore)/2);
            Console.Write("Study score is: {0} points", studyScore);
        }
        public virtual void Read()
        {
            Console.Write("Read score is: {0} points", 2); ;
        }
        public virtual void Write()
        {
            Console.Write("Write score is: {0} points", 3);
        }
        public virtual void Relax()
        {
            Console.Write("Relax score is: {0} points", 4);
        }

        public Pupil(string name, double readScore, double writeScore)
        {
            Console.WriteLine("Name: {0}, Read Score: {1}, Write Score: {2}", name, readScore, writeScore);
        }

    }
}
