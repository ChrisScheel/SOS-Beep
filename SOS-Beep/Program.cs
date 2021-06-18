using System;

namespace SOS_Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Implement infinite loop until user presses a button
            for (int i = 0; i <3; i++)
            {
                Console.Beep(900 ,150);
            }
            Console.Beep(37, 150);
            for (int i = 0; i < 3; i++)
            {
                Console.Beep(900, 400);
            }
            Console.Beep(37, 150);
            for (int i = 0; i < 3; i++)
            {
                Console.Beep(900, 150);
            }
        }
    }
}
