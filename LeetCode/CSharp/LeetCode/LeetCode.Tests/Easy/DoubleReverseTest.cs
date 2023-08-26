using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class DoubleReverseTest
{
    [Fact]
    public void Sample1()
    {
        var worker = new DoubleReverse();

        var input = 525;

        var result = worker.IsSameAfterReversals(input);
        var expected = true;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Sample2()
    {
        var worker = new DoubleReverse();

        var input = 1800;

        var result = worker.IsSameAfterReversals(input);
        var expected = false;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Sample3()
    {
        var worker = new DoubleReverse();

        var input = 0;

        var result = worker.IsSameAfterReversals(input);
        var expected = true;
        
        Assert.Equal(expected, result);
    }
}