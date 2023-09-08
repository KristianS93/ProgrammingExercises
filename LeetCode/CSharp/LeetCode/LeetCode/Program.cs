using BenchmarkDotNet.Running;
using LeetCode.Easy;
using LeetCode.Easy.DynamicProgramming;

namespace LeetCode;

public static class Program
{
    public static void Main()
    {
        var worker = new MinCostClimbingStairsEasy();
        var n = new []{ 10, 15, 20};

        var result = worker.MinCostClimbingStairs(n);
        Console.WriteLine(result);
    }
}