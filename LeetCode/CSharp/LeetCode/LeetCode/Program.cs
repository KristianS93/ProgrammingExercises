using BenchmarkDotNet.Running;
using LeetCode.Easy;
using LeetCode.Medium;

namespace LeetCode;

public static class Program
{
    public static void Main()
    {
        var x = new MaximumOddBinary();
        x.Run();


    }
}