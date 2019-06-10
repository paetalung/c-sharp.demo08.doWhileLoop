using System;

namespace demo08.doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Summon a monster!"); // Create monster
                break;  // Just stop it.
            } while (true);
            Console.WriteLine("End.");
        }
    }
}
