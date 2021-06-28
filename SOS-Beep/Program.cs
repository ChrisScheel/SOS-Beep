using System;

namespace SOS_Beep
{
    class Program
    {
        //Program works only with Windows operating systems
        //TODO:
        //- Modify exception handling so the user can enter a value again
        //- Add maybe something to run beeping and text output parallel
        //  - Handle exception handling elsewhere
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number for the frequency in Hertz.\n" +
                "The number must be between 37 and 32767");
            try
            {
                int frequencyInHertz = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Press Enter to stopp the program after an SOS iteration");
                SOSBeeperGenerator sOSBeeper = new SOSBeeperGenerator(frequencyInHertz);
                sOSBeeper.SignalSOS();
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
    }
}
