using System;
using System.Linq;
using AnagramCheckWebApp.Services;

namespace AnagramCheckWebApp.Models
{
    public class AnagramCheck : IAnagram
    {
        public string CheckIfAnagramOrNot(string firstWord, string secondWord)
        {
            if (firstWord == null || secondWord == null)
            {
                return "Incorrect input...";
            }
            if (String.Concat(firstWord.OrderBy(x => x)).ToLower().Equals
                (String.Concat(secondWord.OrderBy(x => x)).ToLower()) && firstWord != secondWord)
            {
                return "Words are anagram !!";
            }
            else
            {
                return "Sorry your words are not anagram !!";
            }
        }
    }
}
