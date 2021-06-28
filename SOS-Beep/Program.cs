using System;

namespace SOS_Beep
{
    class Program
    {
        //Program only works with Windows operating systems
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number for the frequency in Hertz.\n" +
                "The number must be between 37 and 32767");

            int frequencyInHertz = 0;

            while (!int.TryParse(Console.ReadLine(), out frequencyInHertz))
            {
                Console.WriteLine("\n Your input wasn't a number! Try again");
            }

            //TODO: Fix the input checks. It throws a Format-exception when the user
            //inserts not a number after the range checking
            while (frequencyInHertz < 37 || frequencyInHertz > 32767)
            {
                Console.WriteLine("\n The number must be between 37 und 32767!");
                frequencyInHertz = int.Parse(Console.ReadLine());
            }

            SOSBeeperGenerator sOSBeeper = new SOSBeeperGenerator(frequencyInHertz);
            sOSBeeper.SignalSOS();
        }
    }
}
