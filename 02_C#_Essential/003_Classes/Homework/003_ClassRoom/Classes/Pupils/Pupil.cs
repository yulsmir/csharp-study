using System;
using System.Collections.Generic;
using System.Text;

namespace _003_ClassRoom.Classes.Pupils
{
    class Pupil
    {
        public string name;
        public double readScore;
        public double writeScore;

        public virtual void Read()
        {
            Console.WriteLine("Read score is: {0} points.", readScore);
        }
        public virtual void Write()
        {
            Console.WriteLine("Write score is: {0} points.", writeScore);
        }
        public virtual void Study() 
        {
            double studyScore = Math.Round((readScore + writeScore)/2);
            Console.WriteLine("Study score is: {0} points", studyScore);
        }
       
        public virtual void Relax()
        {
            double relaxScore = (5 - (readScore + writeScore)/2) % 100;
            Console.WriteLine("Relax score is: {0} %.", relaxScore);
        }

        public Pupil()
        {

        }
        public Pupil(string name, double readScore, double writeScore)
        {
            this.name = name;
            this.readScore = readScore;
            this.writeScore = writeScore;
        }

        public void PrintInfo()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Name: {0}", name);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Read Score: {0}", readScore);
            Console.WriteLine("Write Score: {0}", writeScore);
            Study();
            Relax();
            Console.WriteLine(new string('-', 30));
            
        }
    }
}
