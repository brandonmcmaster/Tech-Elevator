using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where, for every string in the array,
         * there is an entry whose key is the first character of the string.
         * 
         * The value of the entry is the last character of the string. If multiple strings start with the same letter, then the value for 
         * that key should be the later string's last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * BeginningAndEnding(["code", "bug", "cat"]) → {"b": "g", "c": "t"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> newDictionary = new Dictionary<string, string>();

            foreach(string newString in words)
            {
                if (!string.IsNullOrEmpty(newString))
                    {
                    string key = newString.Substring(0, 1);
                    string value = newString.Substring(newString.Length - 1);

                    newDictionary[key] = value;
                }
            }
            
            return newDictionary;
        }
    }
}
