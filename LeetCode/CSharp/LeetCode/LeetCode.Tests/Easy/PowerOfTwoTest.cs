using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class PowerOfTwoTest
{
    [Fact]
    public void Sample1()
    {
        var worker = new PowerOfTwo();

        var input = 1;

        var result = worker.IsPowerOfTwo(input);
        var expected = true;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Sample2()
    {
        var worker = new PowerOfTwo();

        var input = 16;

        var result = worker.IsPowerOfTwo(input);
        var expected = true;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Sample3()
    {
        var worker = new PowerOfTwo();

        var input = 3;

        var result = worker.IsPowerOfTwo(input);
        var expected = false;
        
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Sample4()
    {
        var worker = new PowerOfTwo();

        var input = 6;

        var result = worker.IsPowerOfTwo(input);
        var expected = false;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Sample5()
    {
        var worker = new PowerOfTwo();

        var input = 0;

        var result = worker.IsPowerOfTwo(input);
        var expected = false;
        
        Assert.Equal(expected, result);
    }
}