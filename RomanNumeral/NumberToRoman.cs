using System;
using System.Collections.Generic;


namespace RomanNumeral
{
    public class Convertor2
    {
        public static string NumberToRoman(int inputNumber)
        {

            string romanResult = "";
            Dictionary<string, int> romanNumberDictionary = new() {
            {
                "I", 1},
                {"IV",4},
                {"V",5},
                {"IX",9},
                {"X", 10},
                {"XL",40},
                {"L", 50},
                {"XC",90},
                {"C",100},
                {"CD",400},
                {"D",500},
                {"CM",900},
                {"M",1000}
            };

            foreach (var item in romanNumberDictionary.Reverse())
            {
                if (inputNumber <= 0)
                {
                    break;
                }
                while (inputNumber >= item.Value)
                {
                    romanResult += item.Key;
                    inputNumber -= item.Value;
                }
            }
            return romanResult;
        }
    }
}