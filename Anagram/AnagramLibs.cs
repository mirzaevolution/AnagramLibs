using System;
using System.Linq;

namespace Anagram
{
    /// <summary>
    /// General implementation of Anagram Algorithm
    /// </summary>
    public class AnagramLibs
    {
        /// <summary>
        /// Find an anagram of given words
        /// </summary>
        /// <param name="words">Given words cannot be null and should be greater than 2 char(s)</param>
        /// <returns>Anagram table in array of string</returns>
        public static string[] Anagram(string words)
        {
            if (string.IsNullOrEmpty(words))
                throw new ArgumentNullException("words");
            int iterationCount = words.Length;
            string[] resultAnagram = new string[iterationCount * (iterationCount - 1)];
            int globalCounter = 0;
            Func<string, string> swapper = (input) =>
            {
                char[] inputChars = input.ToCharArray();
                string result = "";
                int len = input.Length - 1;
                for (int i = 0; i < len; i++)
                {
                    char temp = inputChars[len - i];
                    inputChars[len - i] = inputChars[(len - i) - 1];
                    inputChars[(len - i) - 1] = temp;
                    result = new string(inputChars);
                    resultAnagram[globalCounter++] = result;
                }
                return result;
            };
            for (int i = 1; i <= iterationCount; i++)
            {
                words = swapper(words);
            }
            return resultAnagram;
        }
        /// <summary>
        /// Compare words to the list of words to check
        /// whether or not they are anagram
        /// </summary>
        /// <param name="words1">Initial words</param>
        /// <param name="wordsN">Words(n) to compare</param>
        /// <param name="caseSensitive">Turn on/off case sensitive mode</param>
        /// <returns>Boolean indicating success/failure</returns>
        public static bool AnagramChecker(string words1, string[] wordsN,bool caseSensitive=false)
        {
            if (string.IsNullOrEmpty(words1))
                throw new ArgumentNullException("words1");
            if (wordsN.Length == 0)
                throw new ArgumentNullException("wordsN");
            bool isTrue = true;
            if(!caseSensitive)
            {
                words1 = new string(words1.ToCharArray().OrderBy(x => x).ToArray()).ToLower();
                foreach(string word in wordsN)
                {
                    string wordToCompare = new 
                        string(word.ToCharArray().OrderBy(x => x).ToArray()).ToLower();
                    if(words1 != wordToCompare)
                    {
                        isTrue = false;
                        break;
                    }

                }
            }
            else
            {
                words1 = new string(words1.ToCharArray().OrderBy(x => x).ToArray());
                foreach (string word in wordsN)
                {
                    string wordToCompare = new
                        string(word.ToCharArray().OrderBy(x => x).ToArray());
                    if (words1 != wordToCompare)
                    {
                        isTrue = false;
                        break;
                    }

                }
            }
            return isTrue;
        }
    }
    
}
