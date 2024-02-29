using LeetCode.Easy.DynamicProgramming;

namespace LeetCode.Tests.Easy.DynamicProgramming;

public class ClimbingStairsTest
{
    [Fact]
    public void SampleTest1()
    {
        var worker = new ClimbingStairs();
        var n = 2;

        var result = worker.ClimbStairs(n);

        var expected = 2;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SampleTest2()
    {
        var worker = new ClimbingStairs();
        var n = 3;

        var result = worker.ClimbStairs(n);

        var expected = 3;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SampleTest3()
    {
        var worker = new ClimbingStairs();
        var n = 5;

        var result = worker.ClimbStairs(n);

        var expected = 8;
        
        Assert.Equal(expected, result);
    }
}