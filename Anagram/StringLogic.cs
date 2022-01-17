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

        internal string cleanString(string stringToBeCleaned)
        {
            return stringToBeCleaned.Replace(" ", "").toup;

        }

        internal bool compareStrings(string string1, string string2)
        {
            // Når mellemrummene er fjernet, skal strengene være lige lange
            // Da de skal bestå af præcis de samme bogstaver for at være anagrammer.
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
