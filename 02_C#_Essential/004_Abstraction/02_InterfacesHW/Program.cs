using System;

namespace _02_InterfacesHW
{
     class Program
    {
        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }

        interface IRecordable
        {
            void Record();
            void Pause();
            void Stop();
        }

        class Player : IPlayable, IRecordable
        {
            void IPlayable.Play()
            {
                Console.WriteLine("Track is playing");
            }

            void IPlayable.Stop()
            {
                Console.WriteLine("Track is stopped");
            }

            void IPlayable.Pause()
            {
                Console.WriteLine("Track is paused");
            }


            void IRecordable.Record()
            {
                Console.WriteLine("Track is recording");
            }

            void IRecordable.Pause()
            {
                Console.WriteLine("Recording is paused");
            }

            void IRecordable.Stop()
            {
                Console.WriteLine("Recording is stopped");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();

            Console.ReadKey();
        }
    }
}
