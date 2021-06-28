using System;
using System.Threading;

namespace SOS_Beep
{
    class SOSBeeperGenerator
    {
        private int frequencyInHertz = 0;
        private readonly int shortBeepInMilliseconds = 220;
        private readonly int longBeepInMilliseconds = 525;
        private readonly string shortBeepSymbol = ". ";
        private readonly string longBeepSymbol = "- ";

        public SOSBeeperGenerator(int frequencyInHertz)
        {
            this.frequencyInHertz = frequencyInHertz;
        }

        public void SignalSOS()
        {
            do
            {
                //Info for me: Console.ReadKey() waits for user input. The program stops till then.
                //With Console.KeyAvailable() that's not the case
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("SOS has stopped");
                        break;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep(frequencyInHertz, shortBeepInMilliseconds);
                    Console.Write($"{shortBeepSymbol}");
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep(frequencyInHertz, longBeepInMilliseconds);
                    Console.Write($"{longBeepSymbol}");
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep(frequencyInHertz, shortBeepInMilliseconds);
                    Console.Write($"{shortBeepSymbol}");
                }
                Console.WriteLine();
                Thread.Sleep(500);
            } while (true);
        }
    }
}
