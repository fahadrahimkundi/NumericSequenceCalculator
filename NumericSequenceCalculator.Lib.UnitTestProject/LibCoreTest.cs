using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator.Lib.Core;
using System.Collections.Generic;

namespace NumericSequenceCalculator.Lib.UnitTestProject
{
    [TestClass]
    public class LibCoreTest
    {
        [TestMethod]
        public void NumericSequence_CheckMultipleOf_Three()
        {
            NumericSequenceGen numericSequenceGen = new NumericSequenceGen();

            int sequenceNum = 3;

            List<string> specialCases = numericSequenceGen.GetSpecialCases(sequenceNum);

            Assert.IsTrue(specialCases.Contains("C"));
        }

        [TestMethod]
        public void NumericSequence_CheckMultipleOf_Five()
        {
            NumericSequenceGen numericSequenceGen = new NumericSequenceGen();

            int sequenceNum = 5;

            List<string> specialCases = numericSequenceGen.GetSpecialCases(sequenceNum);

            Assert.IsTrue(specialCases.Contains("E"));
        }

        [TestMethod]
        public void NumericSequence_CheckMultipleOf_ThreeAndFive()
        {
            NumericSequenceGen numericSequenceGen = new NumericSequenceGen();

            int sequenceNum = 15;

            List<string> specialCases = numericSequenceGen.GetSpecialCases(sequenceNum);

            Assert.IsTrue(specialCases.Contains("Z"));
        }
    }
}