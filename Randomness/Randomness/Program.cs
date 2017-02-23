using System;
using System.Threading;

namespace Randomness
{
    // adding a comment
    class Program
    {
        // Taken from https://msdn.microsoft.com/en-us/library/h343ddh9(v=vs.110).aspx
        public static void Main()
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            Thread.Sleep(2000);
            Random rand3 = new Random();

            // Because the first two Random objects are created in close succession, 
            // they are instantiated using identical seed values based on the system clock and, 
            // therefore, they produce an identical sequence of random numbers.

            Console.WriteLine("Random numbers using same seed value:");
            ShowRandomNumbers(rand1);
            ShowRandomNumbers(rand2);

            // the default constructor of the third Random object is called after a two-second delay 
            // caused by calling the Thread.Sleep method. Because this produces a different seed value 
            // for the third Random object, it produces a different sequence of random numbers. 
            Console.WriteLine();
            Console.WriteLine("Random numbers using different seed value:");

            ShowRandomNumbers(rand3);

            Console.Read();
        }

        private static void ShowRandomNumbers(Random rand)
        {
            Console.WriteLine();
            byte[] values = new byte[5];
            rand.NextBytes(values);
            foreach (byte value in values)
                Console.Write("{0, 5}", value);
            Console.WriteLine();
        }
    }
}

