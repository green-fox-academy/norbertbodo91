using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramClass
{
    public class Anagram
    {
        public bool IsAnagram(string firstWord,string secondWord)
        {
            char[] charFirstWord = firstWord.ToCharArray();
            char[] charSecondWord = secondWord.ToCharArray();

            Array.Sort(charFirstWord);
            Array.Sort(charSecondWord);

            string joinFirstWord = (string.Join("",charFirstWord));
            string joinSecondWord = (string.Join("", charSecondWord));

            if (joinFirstWord == joinSecondWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
