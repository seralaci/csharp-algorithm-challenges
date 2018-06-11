using System.Collections.Generic;
using Challenges.LeetCode.RomanToInteger;
using Xunit;

namespace Challenges.LeetCode.Tests
{
    public class RomanToIntegerTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { "I", 1 };
            yield return new object[] { "III", 3 };
            yield return new object[] { "IV", 4 };
            yield return new object[] { "IX", 9 };
            yield return new object[] { "LVIII", 58 };
            yield return new object[] { "MCMXCIV", 1994 };
            yield return new object[] { "MMMCMXCIX", 3999 };
        }


        [Theory]
        [MemberData(nameof(GetTestData))]
        public void BruteForce(string input, int expectedResult)
        {
            // Arrange 
            var solution = new BruteForce();

            //Assert
            var result = solution.RomanToInt(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void DictionaryPrevSymbolCheck(string input, int expectedResult)
        {
            // Arrange 
            var solution = new DictionaryPrevSymbolCheck();

            //Assert
            var result = solution.RomanToInt(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void DictionaryNextSymbolCheck(string input, int expectedResult)
        {
            // Arrange 
            var solution = new DictionaryNextSymbolCheck();

            //Assert
            var result = solution.RomanToInt(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
