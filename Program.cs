using System;

namespace AnimalEnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new AnimalManager();
            manager.Run();

            Console.WriteLine($"\nTrykk en tast for å avslutte...");
            Console.ReadKey();
        }
    }
}