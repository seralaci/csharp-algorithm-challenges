using System.Collections.Generic;

namespace Challenges.LeetCode.RomanToInteger
{
    public class DictionaryPrevSymbolCheck
    {
        private static readonly Dictionary<char, int> RomanSymbols = new Dictionary<char, int> {
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
            var lastSymbolValue = int.MaxValue;

            foreach(var symbol in s) {
                var symbolValue = RomanSymbols[symbol];

                result += symbolValue;
                // If the symbol value is larger than the previous one, then it's a compound symbol 
                if (symbolValue > lastSymbolValue)
                {
                    result -= 2 * lastSymbolValue;
                }

                lastSymbolValue = symbolValue;
            }

            return result;
        }
    }
}
