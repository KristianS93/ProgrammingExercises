using BenchmarkDotNet.Running;
using LeetCode.Easy;

namespace LeetCode;

public static class Program
{
    public static void Main()
    {
        var summary = BenchmarkRunner.Run<MemoryBenchMarker>();
    }
}