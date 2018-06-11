using System.Collections.Generic;
using Challenges.LeetCode.ReverseInteger;
using Xunit;

namespace Challenges.LeetCode.Tests
{
    public class ReverseIntegerTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { 123, 321 };
            yield return new object[] { -121, -121 };
            yield return new object[] { -123, -321 };
            yield return new object[] { 0, 0 };
            yield return new object[] { 8, 8 };
            yield return new object[] { int.MaxValue, 0 };
            yield return new object[] { int.MinValue, 0};
        }


        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Solution(int input, int expectedResult)
        {
            // Arrange 
            var solution = new Solution();

            //Assert
            var result = solution.Reverse(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
