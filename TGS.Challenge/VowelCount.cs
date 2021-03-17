using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException();
            }
            var vowels = new List<char> { 'a','e','i','o','u' };
            var result = 0;
            foreach (var c in value)
            {
                if(vowels.Contains(Char.ToLower(c)))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
