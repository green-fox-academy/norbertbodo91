using System;
using System.Collections.Generic;
using System.Text;

namespace Countletter
{
    public class ClassCountLetter
    {
        public Dictionary<char, int> CountMyLetter(string countWord)
        {
            var dictWord = new Dictionary<char, int>();
            char[] countWordArray = countWord.ToCharArray();
            for (int i = 0; i < countWordArray.Length; i++)
            {
                dictWord.Add(countWord[i],i);
            }
            return dictWord;
        }
    }
}
