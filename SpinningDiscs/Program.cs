using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD newCD = new CD("Hozier: Best Hits", 25, "CD");
            DVD newDVD = new DVD("Barbie Magic of Pegasus", 50, "DVD");
            // TODO: Call each CD and DVD method to verify that they work as expected.

            Console.WriteLine(newCD + "\n" + newDVD);


        }
    }
}
