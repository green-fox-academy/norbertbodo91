using System;
namespace AnagramCheckWebApp.Services
{
    public interface IAnagram
    {
        string CheckIfAnagramOrNot(string firstWord, string secondWord);
    }
}
