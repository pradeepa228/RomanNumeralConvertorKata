using System;
using System.Collections.Generic;


namespace RomanNumeral
{
    public class Convertor1
    {
        public static int RomanToNumber(string inputString)
        {
            int result = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                int s1 = SingleCharConversion(inputString[i]);
                if (i + 1 < inputString.Length)
                {
                    int s2 = SingleCharConversion(inputString[i + 1]);
                    if (s1 >= s2)
                    {
                        result += s1;
                    }
                    else
                    {
                        result += s2 - s1;
                        i++;
                    }
                }
                else
                {
                    result += s1;
                }

            }
            return result;
        }
        public static int SingleCharConversion(char inputChar)
        {
            switch (inputChar)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default:
                    return 0;
            }
        }
        
    }
}


    

    
