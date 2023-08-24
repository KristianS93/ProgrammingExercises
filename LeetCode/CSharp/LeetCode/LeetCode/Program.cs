using BenchmarkDotNet.Running;
using LeetCode.Easy;

namespace LeetCode;

public static class Program
{
    public static void Main()
    {
        var x = new ValidUniqueMatrice();
        var input = new[]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 2, 3 },
            new int[] { 1, 3, 2 }
        };

        Console.WriteLine(
            
        x.CheckValid(input)
            );

    }
}