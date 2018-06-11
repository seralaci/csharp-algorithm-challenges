using BenchmarkDotNet.Attributes;
using Challenges.LeetCode.RomanToInteger;

namespace Challenges.LeetCode.Tests.Performance
{
    public class RomanToInteger : BenchmarkBase
    {
        [Benchmark(Description = "RomanToInteger.BruteForce")]
        public int BruteForce()
        {
            var solution = new BruteForce();
            return solution.RomanToInt(Input);
        }

        [Benchmark(Description = "RomanToInteger.DictionaryPrevSymbolCheck")]
        public int DictionaryPrevSymbolCheck()
        {
            var solution = new DictionaryPrevSymbolCheck();
            return solution.RomanToInt(Input);
        }

        [Benchmark(Description = "RomanToInteger.DictionaryNextSymbolCheck")]
        public int DictionaryNextSymbolCheck()
        {
            var solution = new DictionaryNextSymbolCheck();
            return solution.RomanToInt(Input);
        }

        private const string Input = "MCMXCIV";
    }
}
