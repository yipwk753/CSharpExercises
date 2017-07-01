using CSharpExercises;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExercisesUnitTestProject
{
    [TestClass]
    public class StringExercisesUnitTest
    {
        StringExercises strExercises = new StringExercises();

        [TestMethod]
        public void AddLettersTest()
        {
            int sum = strExercises.AddLetters("Hello");
            Assert.AreEqual(sum, 52);

            sum = strExercises.AddLetters("0123456789");
            Assert.AreEqual(sum, 0);

            sum = strExercises.AddLetters("1234 !@ -=+   z");
            Assert.AreEqual(sum, 26);
        }

        [TestMethod]
        public void CheckIsPalindromeTest()
        {
            bool isPalindrome = false;
            isPalindrome = strExercises.CheckIsPalindrome("HeeH");
            Assert.IsTrue(isPalindrome);

            isPalindrome = strExercises.CheckIsPalindrome("Hello");
            Assert.IsFalse(isPalindrome);
        }

        [TestMethod]
        public void CountVowelsTest()
        {
            string str = strExercises.CountVowels("Hello World!");
            Assert.AreEqual(str, "Hello World! has 3 vowels: 0 A's, 1 E's, 0 I's, 2 O's, and 0 U's.");
        }

        [TestMethod]
        public void ReverseSentenceTest()
        {
            string reversed = "";
            reversed = strExercises.ReverseSentence("Hello World!");
            Assert.AreEqual("World! Hello", reversed);
        }

        [TestMethod]
        public void ReverseStringTest()
        {
            string reversed = "";
            reversed = strExercises.ReverseString("Hello");
            Assert.AreEqual("olleH", reversed);
        }
    }
}
