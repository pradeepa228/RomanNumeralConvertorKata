using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using System;

namespace RomanNumeral.Tests
{

    public class NumberToRomanUnitTest
    {
        private Convertor2 Convertor2;
        [SetUp]
        public void Setup()
        {
            Convertor2 = new Convertor2();
        }

       
        [Test]
        public void NumberToRoman_Should_Return_IV()
        {
            string outputString = "IV";
            int inputValue = 4;

            string result = Convertor2.NumberToRoman(inputValue);

            result.Should().Be(outputString);
        }

        [Test]
        public void NumberToRoman_Should_Return_V()
        {
            string outputString = "V";
            int inputValue = 5;

            string result = Convertor2.NumberToRoman(inputValue);

            result.Should().Be(outputString);
        }

        [Test]
        public void NumberToRoman_Should_Return_CMXC()
        {
            string outputString = "CMXC";
            int inputValue = 990;

            string result = Convertor2.NumberToRoman(inputValue);

            result.Should().Be(outputString);
        }

        [Test]
        public void NumberToRoman_Should_Return_CCCLX()
        {
            string outputString = "CCCLX";
            int inputValue = 360;

            string result = Convertor2.NumberToRoman(inputValue);

            result.Should().Be(outputString);
        }
    }
}