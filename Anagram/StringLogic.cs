using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAsyncResult = System.IAsyncResult;

namespace Anagram
{
    internal class StringLogic
    {
        internal StringLogic()
        {

        }

        // Her renses strengen for mellemrum og laves til uppercase.
        // Hvis man skal kunne skrive tekst ind med andre tegn som , eller . 
        // så skal disse også fjernes her.
        internal string cleanString(string stringToBeCleaned)
        {
            return stringToBeCleaned.Replace(" ", "").ToUpper();
        }


        // Her trækkes asciiværdien for hver karakter i streng1 
        // fra asciiværdien for hver karakter i streng2 og lægges til balancen.
        // Hvis balancen efter 1 gennemløb af de to strenge er 0
        // betyder det at de har indeholdt de samme bogstaver, og er derfor anagrammer.
        internal bool compareStrings(string string1, string string2)
        {
            // Når mellemrummene er fjernet, skal strengene være lige lange for at være anagrammer.
            int balance = 0;
            bool result = false;

            if (string1.Length == string2.Length)
            {
                for (int counter = 0; counter < string1.Length; counter++)
                {
                    balance = balance + (int) string1[counter] - (int) string2[counter];
                }

                if (balance == 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
