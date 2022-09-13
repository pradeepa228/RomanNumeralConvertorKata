using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using System;

namespace RomanNumeral.Tests
{

   public class RomanToNumberTest
   {
      private Convertor1 Convertor1;
           [SetUp]
       public void Setup()
       {
            Convertor1 = new Convertor1();
       }

        [Test]
        public void RomanToNumber_Should_Return_1()
        {
            string inputString = "I";
            int outputValue = 1;
            
            int result = Convertor1.RomanToNumber(inputString);

            result.Should().Be(outputValue);
        }


        [Test]
        public void RomanToNumber_Should_Return_4()
        {
            string inputString = "IV";
            int outputValue = 4;

            int result = Convertor1.RomanToNumber(inputString);

            result.Should().Be(outputValue);
        }

        [Test]
        public void RomanToNumber_Should_Return_400()
        {

            string inputString = "CD";
            int outputValue = 400;

            int result = Convertor1.RomanToNumber(inputString);

            result.Should().Be(outputValue);
        }

        [Test]
        public void RomanToNumber_Should_Return_0()
        {

            string inputString = "Y";
            int outputValue = 0;

            int result = Convertor1.RomanToNumber(inputString);

            result.Should().Be(outputValue);
        }

        
    }
}   