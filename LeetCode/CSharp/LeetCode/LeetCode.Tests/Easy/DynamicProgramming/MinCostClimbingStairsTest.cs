using LeetCode.Easy.DynamicProgramming;

namespace LeetCode.Tests.Easy.DynamicProgramming;

public class MinCostClimbingStairsTest
{
    [Fact]
    public void SampleTest1()
    {
        var worker = new MinCostClimbingStairsEasy();
        var n = new []{ 10, 15, 20 };

        var result = worker.MinCostClimbingStairs(n);

        var expected = 15;
        
        Assert.Equal(expected, result);
    }
    [Fact]
    public void SampleTest2()
    {
        var worker = new MinCostClimbingStairsEasy();
        var n = new []{ 1,100,1,1,1,100,1,1,100,1 };

        var result = worker.MinCostClimbingStairs(n);

        var expected = 6;
        
        Assert.Equal(expected, result);
    }
}