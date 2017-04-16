using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace Anagram.Test
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void Anagram_Success()
        {
            string word1 = "abcd";
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
            string word2 = "abcde";
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
            string[] actualResult1 = AnagramLibs.Anagram(word1);
            CollectionAssert.AreEqual(actualResult1,definedResult1);
            //2nd Test...
            string[] actualResult2 = AnagramLibs.Anagram(word2);
            CollectionAssert.AreEqual(actualResult2,definedResult2);
            
        }
        [TestMethod]
        public void Anagram_Failed()
        {
            string word1 = "abcd";
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
                "abcd",
                "abcd" //same word will cause a failure
            };
            string word2 = "abcde";
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
                "abcde",
                "abcde" //same word will cause a failure
            };
            //1st Test...
            string[] actualResult1 = AnagramLibs.Anagram(word1);
            CollectionAssert.AreNotEqual(actualResult1, definedResult1);
            //2nd Test...
            string[] actualResult2 = AnagramLibs.Anagram(word2);
            CollectionAssert.AreNotEqual(actualResult2, definedResult2);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnagramArgument_Failed()
        {
            string str1 = "";
            string str2 = null;
            AnagramLibs.Anagram(str1);
            AnagramLibs.Anagram(str2);
        }
        [TestMethod]
        public void AnagramChecker_InCaseSensitive_Success()
        {
            string word1 = "abcd";
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
            Assert.IsTrue(AnagramLibs.AnagramChecker(word1, definedResult1));
        }
        [TestMethod]
        public void AnagramChecker_CaseSensitive_Success()
        {
            string word1 = "AbCd";
            string[] definedResult1 = new[]
            {
                "AbdC",
                "AdbC",
                "dAbC",
                "dACb",
                "dCAb",
                "CdAb",
                "CdbA",
                "CbdA",
                "bCdA",
                "bCAd",
                "bACd",
                "AbCd"
            };
            Assert.IsTrue(AnagramLibs.AnagramChecker(word1, definedResult1,true));
        }
        [TestMethod]
        public void AnagramChecker_Failed()
        {
            string word1 = "abcd";
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
                "abcd",
                "aabb"
            };
            Assert.IsFalse(AnagramLibs.AnagramChecker(word1, definedResult1));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnagramCheckerArgument1_Failed()
        {
            string word1 = "";
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
                "abcd",
                "aabb"
            };

            Assert.IsTrue(AnagramLibs.AnagramChecker(word1, definedResult1));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AnagramCheckerArgument2_Failed()
        {
            string word1 = "test";
            string[] definedResult1 = new string[0];
            Assert.IsTrue(AnagramLibs.AnagramChecker(word1, definedResult1));
        }
    }
}
