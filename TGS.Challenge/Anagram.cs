using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
            if(string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException();
            }
            var punctuationList = new List<char> {' ','.',',','/','?',':',';','"','|','\'','`','!','@','#','&','_','-' };
            
            foreach (var c in word1)
            {
                if(punctuationList.Contains(c))
                {
                    continue;
                }
                if(word2.Length > 0 && word2.Contains(c,StringComparison.InvariantCultureIgnoreCase))
                {
                    var startIndex = word2.IndexOf(c, StringComparison.InvariantCultureIgnoreCase);
                    word2 = word2.Remove(startIndex, 1);
                }
                else
                {
                    return false;
                }
            }

            foreach (var w in word2)
            {
                if (punctuationList.Contains(w))
                {
                    var startIndex = word2.IndexOf(w);
                    word2 = word2.Remove(startIndex, 1);
                }
            }
            if (word2.Length > 0)
            {
                return false;
            }
            return true;
      }
    }
}
