﻿using CSharpExercises;
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
        public void CheckIfNumberIsCompositeTest()
        {
            bool isComposite = intExercises.CheckIfNumberIsComposite(8);
            Assert.IsTrue(isComposite);

            isComposite = intExercises.CheckIfNumberIsComposite(7);
            Assert.IsFalse(isComposite);

            isComposite = intExercises.CheckIfNumberIsComposite(2);
            Assert.IsFalse(isComposite);
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
        public void FindNPrimeTest()
        {
            int primeNum = intExercises.FindNPrime(5);
            Assert.AreEqual(primeNum, 11);

            primeNum = intExercises.FindNPrime(1);
            Assert.AreEqual(primeNum, 2);
        }

        [TestMethod]
        public void FindPythagoreanTripletTest()
        {
            var pythagoreanTriplet = intExercises.FindPythagoreanTriplet(12);
            Assert.AreEqual(3, pythagoreanTriplet.Item1);
            Assert.AreEqual(4, pythagoreanTriplet.Item2);
            Assert.AreEqual(5, pythagoreanTriplet.Item3);
            Assert.AreEqual(60, pythagoreanTriplet.Item4);
            Assert.IsTrue(pythagoreanTriplet.Item5);
        }

        [TestMethod]
        public void FindTriangleDivisorTest()
        {
            var triangleDivisor = intExercises.FindTriangleDivisor(4);
            Assert.IsTrue(triangleDivisor.Count == 4);
            Assert.AreEqual(1, triangleDivisor[0]);
            Assert.AreEqual(2, triangleDivisor[1]);
            Assert.AreEqual(3, triangleDivisor[2]);
            Assert.AreEqual(6, triangleDivisor[3]);

            /*triangleDivisor = intExercises.FindTriangleDivisor(500);
            Assert.IsTrue(triangleDivisor.Count >= 500);
            Assert.AreEqual(76576500, triangleDivisor[576]);*/
        }

        [TestMethod]
        public void GetFactorsOfCompositeNumberTest()
        {
            List<int> numList = new List<int>();
            numList = intExercises.GetFactorsOfCompositeNumber(10);
            Assert.IsTrue(numList.Count > 0);

            numList = intExercises.GetFactorsOfCompositeNumber(7);
            Assert.IsTrue(numList.Count == 0);
        }

        [TestMethod]
        public void LargestPalindromeProductTest()
        {
            Tuple<int, int, bool> tuple = intExercises.LargestPalindromeProduct(999, 99);
            Assert.IsTrue(tuple.Item3);
            Assert.AreEqual(tuple.Item1, 999);
            Assert.AreEqual(tuple.Item2, 91);
            Assert.AreEqual(tuple.Item1 * tuple.Item2, 90909);
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
        public void LargestProductInA1X1GridTest()
        {
            int[,] grid = new int[1, 1];
            grid[0, 0] = 5;
            int adjacentNumbers = 1;
            GridDetails gridDetails = intExercises.LargestProductInAGrid(grid, adjacentNumbers);
            Assert.AreEqual("None", gridDetails.Direction);
            Assert.AreEqual(5, gridDetails.Product);
            Assert.AreEqual(5, gridDetails.GridValues[0]);
            Assert.AreEqual("[0,0]", gridDetails.GridIndexes[0]);
        }

        [TestMethod]
        public void LargestProductInA1X5GridTest()
        {
            int[,] grid = new int[1, 5];
            grid[0, 0] = 2;
            grid[0, 1] = 44;
            grid[0, 2] = 75;
            grid[0, 3] = 33;
            grid[0, 4] = 53;
            int adjacentNumbers = 2;
            GridDetails gridDetails = intExercises.LargestProductInAGrid(grid, adjacentNumbers);
            Assert.AreEqual("Horizontal", gridDetails.Direction);
            Assert.AreEqual(3300, gridDetails.Product);
            Assert.AreEqual(44, gridDetails.GridValues[0]);
            Assert.AreEqual(75, gridDetails.GridValues[1]);
            Assert.AreEqual("[0,1]", gridDetails.GridIndexes[0]);
            Assert.AreEqual("[0,2]", gridDetails.GridIndexes[1]);
        }

        [TestMethod]
        public void LargestProductInA5X1GridTest()
        {
            int[,] grid = new int[5, 1];
            grid[0, 0] = 2;
            grid[1, 0] = 44;
            grid[2, 0] = 75;
            grid[3, 0] = 33;
            grid[4, 0] = 53;
            int adjacentNumbers = 2;
            GridDetails gridDetails = intExercises.LargestProductInAGrid(grid, adjacentNumbers);
            Assert.AreEqual("Vertical", gridDetails.Direction);
            Assert.AreEqual(3300, gridDetails.Product);
            Assert.AreEqual(44, gridDetails.GridValues[0]);
            Assert.AreEqual(75, gridDetails.GridValues[1]);
            Assert.AreEqual("[1,0]", gridDetails.GridIndexes[0]);
            Assert.AreEqual("[2,0]", gridDetails.GridIndexes[1]);
        }

        [TestMethod]
        public void LargestProductInA5X5GridTest()
        {
            int[,] grid = new int[5, 5];
            grid[0, 0] = 2;
            grid[0, 1] = 44;
            grid[0, 2] = 75;
            grid[0, 3] = 33;
            grid[0, 4] = 53;
            grid[1, 0] = 10;
            grid[1, 1] = 26;
            grid[1, 2] = 38;
            grid[1, 3] = 40;
            grid[1, 4] = 67;
            grid[2, 0] = 20;
            grid[2, 1] = 95;
            grid[2, 2] = 63;
            grid[2, 3] = 94;
            grid[2, 4] = 39;
            grid[3, 0] = 26;
            grid[3, 1] = 97;
            grid[3, 2] = 17;
            grid[3, 3] = 78;
            grid[3, 4] = 78;
            grid[4, 0] = 44;
            grid[4, 1] = 20;
            grid[4, 2] = 45;
            grid[4, 3] = 35;
            grid[4, 4] = 14;
            int adjacentNumbers = 4;
            GridDetails gridDetails = intExercises.LargestProductInAGrid(grid, adjacentNumbers);
            Assert.AreEqual(21941010, gridDetails.Product);
            Assert.AreEqual("Horizontal", gridDetails.Direction);
        }

        [TestMethod]
        public void LargestProductInSeriesTest()
        {
            string numSeries = @"
            73167176531330624919225119674426574742355349194934
            96983520312774506326239578318016984801869478851843
            85861560789112949495459501737958331952853208805511
            12540698747158523863050715693290963295227443043557
            66896648950445244523161731856403098711121722383113
            62229893423380308135336276614282806444486645238749
            30358907296290491560440772390713810515859307960866
            70172427121883998797908792274921901699720888093776
            65727333001053367881220235421809751254540594752243
            52584907711670556013604839586446706324415722155397
            53697817977846174064955149290862569321978468622482
            83972241375657056057490261407972968652414535100474
            82166370484403199890008895243450658541227588666881
            16427171479924442928230863465674813919123162824586
            17866458359124566529476545682848912883142607690042
            24219022671055626321111109370544217506941658960408
            07198403850962455444362981230987879927244284909188
            84580156166097919133875499200524063689912560717606
            05886116467109405077541002256983155200055935729725
            71636269561882670428252483600823257530420752963450
            ";
            long product = intExercises.LargestProductInSeries(numSeries, 4);
            Assert.AreEqual(product, 5832);

            product = intExercises.LargestProductInSeries(numSeries, 13);
            Assert.AreEqual(product, 5377010688);

            product = intExercises.LargestProductInSeries("1234", 3);
            Assert.AreEqual(product, 24);
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
        public void PrimeNumberSieveTest()
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

        [TestMethod]
        public void SmallestMultipleTest()
        {
            int smallestMultiple = intExercises.SmallestMultiple(10);
            Assert.AreEqual(smallestMultiple, 2520);

            smallestMultiple = intExercises.SmallestMultiple(3);
            Assert.AreEqual(smallestMultiple, 6);

            smallestMultiple = intExercises.SmallestMultiple(6);
            Assert.AreEqual(smallestMultiple, 60);
        }

        [TestMethod]
        public void SummationOfPrimesTest()
        {
            long sum = intExercises.SummationOfPrimes(10);
            Assert.AreEqual(sum, 17);
        }

        [TestMethod]
        public void SumSquareDifferenceTest()
        {
            long difference = intExercises.SumSquareDifferences(10);
            Assert.AreEqual(difference, 2640);

            difference = intExercises.SumSquareDifferences(1);
            Assert.AreEqual(difference, 0);

            difference = intExercises.SumSquareDifferences(2);
            Assert.AreEqual(difference, 4);
        }
    }
}
