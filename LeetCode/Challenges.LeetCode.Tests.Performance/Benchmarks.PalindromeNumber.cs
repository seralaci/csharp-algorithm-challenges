using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.PalindromeNumber;

namespace Challenges.LeetCode.Tests.Performance
{
    public class PalindromeNumber : BenchmarkBase
    {
        [Benchmark(Description = "PalindromeNumber.Reverse")]
        public bool Reverse()
        {
            var solution = new Reverse();
            return solution.IsPalindrome(X);
        }

        [Benchmark(Description = "PalindromeNumber.CompareLastAndFirst")]
        public bool CompareLastAndFirst()
        {
            var solution = new CompareLastAndFirst();
            return solution.IsPalindrome(X);
        }

        private const int X = 789544123;
    }
}
