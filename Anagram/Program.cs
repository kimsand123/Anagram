using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AnagramTestProject")]

namespace Anagram
{
    class Program
    {

        static void Main(string[] args)
        {
            StringLogic _stringHandler = new();

            Console.Write("Indtast streng 1: ");
            string string1 = Console.ReadLine();
            Console.Write("Indtast streng 2: ");
            string string2 = Console.ReadLine();

            string cleanedString1 = _stringHandler.cleanString(string1);
            string cleanedString2 = _stringHandler.cleanString(string2);

            if (_stringHandler.compareStrings(cleanedString1, cleanedString2))
            {
                Console.WriteLine("\n De to strenge er anagrammer.");
            }
            else
            {
                Console.WriteLine("\nDe to strenge er ikke anagrammer.");
            }


        }
    }
}
