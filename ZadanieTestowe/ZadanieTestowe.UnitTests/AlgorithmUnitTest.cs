using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZadanieTestowe;

namespace ZadanieTestowe.UnitTests
{
    [TestClass]
    public class AlgorithmUnitTest
    {
        [TestMethod]
        public void GeneralTest_Pass_If_Result_IsEqual_To_ExpectedResult()
        {
            double h = 10;
            double b = 0.7;
            double w = 1.5;
            int result = 5;

            var algorithmResult = new Algorithm(h, b, w).NumberOfReflections();

            Assert.AreEqual(result, algorithmResult);

        }

        [TestMethod]
        public void TestCase1_Pass_If_Result_IsEqual_To_ExpectedResult()
        {
            double h = 10;
            double b = 1;
            double w = 1.5;
            int result = -1;

            var algorithmResult = new Algorithm(h, b, w).NumberOfReflections();

            Assert.AreEqual(result, algorithmResult);

        }

        [TestMethod]
        public void TestCase2_Pass_If_Result_IsEqual_To_ExpectedResult()
        {
            double h = 10;
            double b = 0.7;
            double w = 1.3;
            int result = -1;

            var algorithmResult = new Algorithm(h, b, w).NumberOfReflections();

            Assert.AreEqual(result, algorithmResult);

        }
    }
}
