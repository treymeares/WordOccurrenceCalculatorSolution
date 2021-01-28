using NUnit.Framework;
using WordOccurrenceCalculator;
using System.Collections;
using System;


namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
       
        }

        

        
        [Test]

        public void Test2()
        {
            var input = new ArrayList(null);
            
            var expectedOutput = "";
            var actualOutput = WordCalculator.CalculateOccurrences(input);
            Assert.AreEqual(expectedOutput, actualOutput, "Invalid Entry");

        }
    }
}