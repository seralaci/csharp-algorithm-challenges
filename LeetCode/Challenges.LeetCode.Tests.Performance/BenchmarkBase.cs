using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Order;

namespace Challenges.LeetCode.Tests.Performance
{
    [OrderProvider(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [Config(typeof(BenchmarkConfig))]
    public abstract class BenchmarkBase
    {       
    }
}
