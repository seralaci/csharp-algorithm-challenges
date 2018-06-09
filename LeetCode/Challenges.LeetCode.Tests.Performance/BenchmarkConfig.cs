using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;

namespace Challenges.LeetCode.Tests.Performance
{
   
    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            Add(new MemoryDiagnoser());
            Add(Job.Default
                .WithLaunchCount(1)
                .WithWarmupCount(0)
                .WithTargetCount(5)
                .WithRemoveOutliers(true)
            );
        }
    }
}
