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

        /*[TestMethod]
        public void PrimeNumberSieveTest()
        {
            List<int> numList = new List<int>();
            numList = intExercises.PrimeNumberSieve(10);
            Assert.IsTrue(numList.Count > 0);

            numList = intExercises.PrimeNumberSieve(7);
            Assert.IsTrue(numList.Count == 0);
        }*/
    }
}
