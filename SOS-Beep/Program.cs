using System;
using System.Threading;

namespace SOS_Beep
{
    class Program
    {
        //Program works only with Windows operating systems
        //TODO:
        //- Modify exception handling so the user can enter a value again
        //- Add maybe something to run beeping and text output parallel
        //- Refactor code because it became too big:
        //  - Handle exception handling elsewhere
        //  - Split the SignalSOS() method to make it more readable
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number for the frequency in Hertz.\n" +
                "The number must be between 37 and 32767");
            try
            {
                int frequencyInHertz = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Press Enter to stopp the program after an SOS iteration");
                SignalSOS(frequencyInHertz);
            }
            catch (System.FormatException)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.WriteLine("\n Your input wasn't a number!");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                Console.WriteLine("\n The number must be between 37 und 32767!");
            }
        }

        static void SignalSOS(int frequency)
        {
            int frequencyInHertz = frequency;
            int shortBeepInMilliseconds = 220;
            int longBeepInMilliseconds = 525;
            string shortBeepSymbol = ". ";
            string longBeepSymbol = "- ";

            do
            {
                //Info for me: Console.ReadKey() waits for user input. The program stops till then.
                //With Console.KeyAvailable() that's not the case
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("SOS stopped");
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
