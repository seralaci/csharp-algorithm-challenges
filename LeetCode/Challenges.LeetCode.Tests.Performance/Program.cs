using System.Linq;
using System.Reflection;
using BenchmarkDotNet.Running;
using static System.Console;

namespace Challenges.LeetCode.Tests.Performance
{
    public class Program
    {
        public static void Main(string[] args)
        {
#if DEBUG
            WriteLine("Warning: DEBUG configuration; performance may be impacted!");
            WriteLine();
#endif

            if (args.Length == 0)
            {
                WriteLine("Optional arguments:");
                WriteLine("  --all : run all benchmarks");
                WriteLine();
            }

            if (args.Any(a => a == "--all"))
            {
                var benchmarkTypes = Assembly.GetEntryAssembly().DefinedTypes.Where(t => t.IsSubclassOf(typeof(BenchmarkBase)));
                var benchmarks = benchmarkTypes.SelectMany(t => BenchmarkConverter.TypeToBenchmarks(t)).ToArray();
                WriteLine("Running full benchmarks suite");

                BenchmarkRunner.Run(benchmarks, null);
            }
            else
            {
                BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
            }
        }
    }
}
