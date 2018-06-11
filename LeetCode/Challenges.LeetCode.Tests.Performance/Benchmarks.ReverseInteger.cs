using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.ReverseInteger;

namespace Challenges.LeetCode.Tests.Performance
{
    public class ReverseInteger : BenchmarkBase
    {
        [Benchmark(Description = "PalindromeNumber.ReverseInteger")]
        public int Solution()
        {
            var solution = new Solution();
            return solution.Reverse(X);
        }

        private const int X = 789544123;
    }
}
