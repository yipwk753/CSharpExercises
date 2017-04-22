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
        public void CheckIsPalindromeTest()
        {
            bool isPalindrome = false;
            isPalindrome = strExercises.CheckIsPalindrome("HeeH");
            Assert.IsTrue(isPalindrome);

            isPalindrome = strExercises.CheckIsPalindrome("Hello");
            Assert.IsFalse(isPalindrome);
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
