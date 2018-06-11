using System;
using System.Collections.Generic;

namespace Challenges.LeetCode.RomanToInteger
{
    public class DictionaryNextSymbolCheck
    {
        private static Dictionary<char, int> RomanSymbols = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int RomanToInt(string s) 
        {
            var result = 0;
            var chars = s.ToCharArray();

            for (var i = 0; i < chars.Length; i++)
            {
                var currentSymbolValue =  RomanSymbols[chars[i]];
                if (i < chars.Length - 1) {
                    var nextSymbolValue =  RomanSymbols[chars[i + 1]];   

                    // If the symbol value is smaller than the next one, then it's a compound symbol 
                    if (currentSymbolValue < nextSymbolValue) {
                        result += nextSymbolValue - currentSymbolValue;
                        i++;  
                        continue;
                    }      
                }  

                result += currentSymbolValue;
            }

            return result;
        }
    }
}
