using System.Linq;
using System.Reflection;
using BenchmarkDotNet.Running;
using static System.Console;

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
    WriteLine("Running full benchmarks suite");

    BenchmarkRunner.Run(Assembly.GetEntryAssembly());
}
else
{
    BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
}
        
