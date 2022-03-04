using System.Collections.Generic;
using Challenges.LeetCode.RomanToInteger;
using Xunit;

namespace Challenges.LeetCode.Tests;

public class RomanToIntegerTests
{
    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { "I", 1 };
        yield return new object[] { "II", 2 };
        yield return new object[] { "III", 3 };
        yield return new object[] { "IV", 4 };
        yield return new object[] { "V", 5 };
        yield return new object[] { "VI", 6 };
        yield return new object[] { "VII", 7 };
        yield return new object[] { "VIII", 8 };
        yield return new object[] { "IX", 9 };
        yield return new object[] { "X", 10 };
        yield return new object[] { "XC", 90 };
        yield return new object[] { "C", 100 };
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