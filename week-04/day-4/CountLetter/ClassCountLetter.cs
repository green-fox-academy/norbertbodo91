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
            
            for (int i = 0; i < countWord.Length; i++)
            {
                if (dictWord.ContainsKey(countWord[i]))
                {
                    dictWord[countWord[i]]++;
                }
                else
                {
                dictWord.Add(countWord[i],i);
                }
            }
            return dictWord;
        }
    }
}
