﻿using System;
using System.Threading;

namespace SOS_Beep
{
    class Program
    {
        //Program works only with Windows operating systems
        //TODO: Implement KeyListener to exit program after user pressed Enter
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number for the frequency in Hertz.\n" +
                "The number must be between 37 and 32767");
            int frequencyInHertz = int.Parse(Console.ReadLine());
            SignalSOS(frequencyInHertz);
        }

        static void SignalSOS(int frequency)
        {
            int frequencyInHertz = frequency;
            int shortBeepInMilliseconds = 220;
            int longBeepInMilliseconds = 525;
            string shortBeepSymbol = ". ";
            string longBeepSymbol = "- ";

            while (true)
            {
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
            }
        }
    }
}
