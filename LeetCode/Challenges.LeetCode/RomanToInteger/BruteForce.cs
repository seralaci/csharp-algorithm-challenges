using System;
using System.Collections.Generic;

namespace Challenges.LeetCode.RomanToInteger
{
    public class BruteForce
    {
        public int RomanToInt(string s) 
        {
            var result = 0;
            var chars = s.ToCharArray();

            for (var i = 0; i < chars.Length; i++)
            {
                var lastSymbol = i == chars.Length - 1;

                switch(chars[i]) {
                    case 'M':
                        result += 1000;
                        break;

                    case 'D':
                        result += 500;
                        break;

                    case 'C':
                        if (!lastSymbol) {
                            switch(chars[i + 1]) {
                                case 'M':
                                    result += 900;
                                    i++;
                                    continue;

                                case 'D':
                                    result += 400;
                                    i++;
                                    continue;
                            }
                        }  
                        result += 100;
                        break;

                    case 'L':
                        result += 50;
                        break;

                    case 'X':
                        if (!lastSymbol) {
                            switch(chars[i + 1]) {
                                case 'C':
                                    result += 90;
                                    i++;
                                    continue;

                                case 'L':
                                    result += 40;
                                    i++;
                                    continue;
                            }
                        }
                        result += 10;
                        break;

                    case 'V':
                        result += 5;
                        break;

                    case 'I':
                        if (!lastSymbol) {
                            switch(chars[i + 1]) {
                                case 'X':
                                    result += 9;
                                    i++;
                                    continue;

                                case 'V':
                                    result += 4;
                                    i++;
                                    continue;
                            }
                        }
                        result += 1;
                        break;
                }
            }

            return result;
        }
    }
}
