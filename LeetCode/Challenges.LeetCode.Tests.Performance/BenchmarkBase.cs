using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Challenges.LeetCode.Tests.Performance;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
[Config(typeof(BenchmarkConfig))]
public abstract class BenchmarkBase
{ }