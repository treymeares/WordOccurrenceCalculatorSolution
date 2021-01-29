using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections;
using WordOccurrenceCalculator;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]

        public void CalculateOccurrencesTest()
        {
            //Arrange
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
            String outputString = "";

            for (int i = 0; i < obj.Length; i++)
            {
                string countResult = obj[i].Word + " = " + obj[i].Count + "\n";
                outputString = outputString + countResult;
            }
            var finalOutput = outputString;


            var expectedOutput = "This = 1\nlittle = 1\npiggy = 1\n";

            //Act
            var actualOutput = WordCalculator.CalculateOccurrences(inputList);

            //Assert
            NUnit.Framework.Assert.AreEqual(expectedOutput, finalOutput, "Invalid Result");
        }



        [Test]
        public void CalculateOccurrencesShouldThrowExceptionsts()
        {
            
            // Using a method as a delegate
            Assert.Throws<ArgumentNullException>(MethodThatThrows);
            
        }
        
        void MethodThatThrows()
        {
            ArrayList inputList = new ArrayList();
            var actualOutput = WordCalculator.CalculateOccurrences(inputList);
        }


    }
}


      
    


