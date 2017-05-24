using CSharpExercises;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharpExercisesUnitTestProject
{
    [TestClass]
    public class IntegerExercisesUnitTest
    {
        IntegerExercises intExercises = new IntegerExercises();

        [TestMethod]
        public void CheckIfCompositeNumberTest()
        {
            List<int> numList = new List<int>();
            numList = intExercises.CheckIfCompositeNumber(10);
            Assert.IsTrue(numList.Count > 0);

            numList = intExercises.CheckIfCompositeNumber(7);
            Assert.IsTrue(numList.Count == 0);
        }

        [TestMethod]
        public void EvenFibonacciNumbersSumTest()
        {
            int sum = intExercises.EvenFibonacciNumbersSum(10);
            Assert.AreEqual(sum, 44);

            sum = intExercises.EvenFibonacciNumbersSum(1);
            Assert.AreEqual(sum, 0);
        }

        [TestMethod]
        public void FibonacciSequenceTest()
        {
            List<int> sequence = new List<int>();
            sequence = intExercises.FibonacciSequence(7);
            Assert.IsTrue(sequence.Contains(0));
            Assert.IsTrue(sequence.Contains(1));
            Assert.IsTrue(sequence.Contains(2));
            Assert.IsTrue(sequence.Contains(3));
            Assert.IsTrue(sequence.Contains(5));
            Assert.IsTrue(sequence.Contains(8));
        }

        [TestMethod]
        public void FindLeastCommonDenominatorTest()
        {
            int lcdNum = intExercises.FindLeastCommonDenominator(3, 4);
            Assert.IsTrue(lcdNum == 12);

            lcdNum = intExercises.FindLeastCommonDenominator(4, 8);
            Assert.IsTrue(lcdNum == 8);

            lcdNum = intExercises.FindLeastCommonDenominator(5, 5);
            Assert.IsTrue(lcdNum == 5);

            lcdNum = intExercises.FindLeastCommonDenominator(1, 4);
            Assert.IsTrue(lcdNum == 4);
        }

        [TestMethod]
        public void LargestPrimeFactorTest()
        {
            int primeFactor = intExercises.LargestPrimeFactor(81);
            Assert.AreEqual(primeFactor, 3);

            primeFactor = intExercises.LargestPrimeFactor(100);
            Assert.AreEqual(primeFactor, 5);
        }

        [TestMethod]
        public void MultiplesOf3And5Test()
        {
            int sum = intExercises.MultiplesOf3And5(20);
            Assert.IsTrue(sum == 98);

            sum = intExercises.MultiplesOf3And5(-18);
            Assert.IsTrue(sum == -78);
        }

        [TestMethod]
        public void PrimeNumberSieve()
        {
            List<int> primeNumList = new List<int>();
            primeNumList = intExercises.PrimeNumberSieve(12);
            Assert.IsTrue(primeNumList.Contains(1));
            Assert.IsTrue(primeNumList.Contains(2));
            Assert.IsTrue(primeNumList.Contains(3));
            Assert.IsFalse(primeNumList.Contains(4));
            Assert.IsTrue(primeNumList.Contains(5));
            Assert.IsFalse(primeNumList.Contains(6));
            Assert.IsTrue(primeNumList.Contains(7));
            Assert.IsFalse(primeNumList.Contains(8));
            Assert.IsFalse(primeNumList.Contains(9));
            Assert.IsFalse(primeNumList.Contains(10));
            Assert.IsTrue(primeNumList.Contains(11));
            Assert.IsFalse(primeNumList.Contains(12));
        }
    }
}
