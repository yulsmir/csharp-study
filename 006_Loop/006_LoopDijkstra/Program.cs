using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_LoopDijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = '\0';
            for (; ; )
            {
                character = Console.ReadKey().KeyChar;
                switch (character)
                {
                    case 'l':
                        {
                            Console.WriteLine(" Go Left");
                            continue;
                        }
                    case 'r':
                        {
                            Console.WriteLine(" Go Right");
                            continue;
                        }

                }
                break;
                Console.ReadKey();
                }
            }
        }
    }
