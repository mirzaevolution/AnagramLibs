using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram.Test
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void Anagram_Success()
        {
            string words1 = "abcd";
            string[] definedResult1 = new[]
            {
                "abdc",
                "adbc",
                "dabc",
                "dacb",
                "dcab",
                "cdab",
                "cdba",
                "cbda",
                "bcda",
                "bcad",
                "bacd",
                "abcd"
            };
            string words2 = "abcde";
            string[] definedResult2 = new[]
            {
                "abced",
                "abecd",
                "aebcd",
                "eabcd",
                "eabdc",
                "eadbc",
                "edabc",
                "deabc",
                "deacb",
                "decab",
                "dceab",
                "cdeab",
                "cdeba",
                "cdbea",
                "cbdea",
                "bcdea",
                "bcdae",
                "bcade",
                "bacde",
                "abcde"
            };
            //1st Test...
            string[] actualResult1 = AnagramLibs.Anagram(words1);
            CollectionAssert.AreEquivalent(actualResult1, definedResult1);

            //2nd Test...
            string[] actualResult2 = AnagramLibs.Anagram(words2);
            CollectionAssert.AreEquivalent(actualResult2, definedResult2);
        }
    }
}
