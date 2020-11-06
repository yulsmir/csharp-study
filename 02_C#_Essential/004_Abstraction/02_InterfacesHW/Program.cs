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

        interface IRecordable : IPlayable
        {
            void Record();
        }

        class Player : IRecordable
        {
            public void Play()
            {
                Console.WriteLine("Track is playing");
            }

            public void Stop()
            {
                Console.WriteLine("Track is stopped");
            }

            public void Pause()
            {
                Console.WriteLine("Track is paused");
            }

            public void Record()
            {
                Console.WriteLine("Track is recording");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Record();
            player.Stop();
            player.Pause();

            Console.ReadKey();
        }
    }
}
