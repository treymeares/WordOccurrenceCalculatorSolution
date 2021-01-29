using NUnit.Framework;
using WordOccurrenceCalculator;
using System.Collections;
using System;
using System.Windows.Forms;

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

            String inputText = "This little piggy";
            String[] createSplitString = inputText.Split(' ');


            ArrayList inputList = new ArrayList();
            for (int i = 0; i < createSplitString.Length; i++)
                inputList.Add(createSplitString[i]);
            if (createSplitString[0] == "")
            {
                inputList.Remove(createSplitString[0]);
            }
            WordOccurrence[] obj = WordCalculator.CalculateOccurrences(inputList);

            var expectedOutput = "This = 1\nlittle = 1\npiggy. = 1\n";
            var actualOutput = WordCalculator.CalculateOccurrences(inputList);

            Assert.AreEqual(expectedOutput, actualOutput, "Invalid Result");
        }


        [Test]

        public void Test2()
        {

            Assert.Pass();
        }

        [Test]
        public void Test3()
        {

            ArrayList inputList = new ArrayList();
       

            var expectedOutput = "";
            var actualOutput = WordCalculator.CalculateOccurrences(inputList);

            Assert.AreEqual(expectedOutput, actualOutput, "Invalid Result");
        }
    }



}