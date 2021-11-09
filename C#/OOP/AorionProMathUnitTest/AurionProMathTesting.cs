using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AurionProMathCalculator;

namespace AorionProMathUnitTest
{
    [TestClass]
    public class AurionProMathTesting
    {
        [TestMethod]
        public void TestForCheckPrimeNo()
        {
            AurionProMath math = new AurionProMath();
            bool actual = math.CheckPrimeNo(1);

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void TestForGeneratePrimeNo()
        {
            int[] primeNos = new int[] { 1,2,3,5,7};
            AurionProMath math = new AurionProMath();
            int[] generatedPrime = math.GeneratePrimeNosTill(10);

            Assert.AreEqual(primeNos[1], generatedPrime[1]);
        }
    }
}
