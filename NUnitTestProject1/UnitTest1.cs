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
        public void Test1()
        {
            ArrayList input = new ArrayList
            {
                "This",
                "little",
                "piggy"
            };

            var expected = "This = 1 \n little = 1 \n piggy. = 1";
            var actual = WordCalculator.CalculateOccurrences(input);

           

        }
    }
}