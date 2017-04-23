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
    }
}
