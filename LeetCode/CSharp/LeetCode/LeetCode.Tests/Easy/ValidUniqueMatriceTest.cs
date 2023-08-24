using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class ValidUniqueMatriceTest
{
    [Fact]
    public void Sample1()
    {
        var worker = new ValidUniqueMatrice();
        var input = new[]
        {
            new int[] { 1, 2, 3 },
            new int[] { 3, 1, 2 },
            new int[] { 2, 3, 1 }
        };

        var result = worker.CheckValid(input);
        var expected = true;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Sample2()
    {
        var worker = new ValidUniqueMatrice();
        var input = new[]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 2, 3 },
            new int[] { 1, 2, 3 }
        };

        var result = worker.CheckValid(input);
        var expected = false;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Sample3()
    {
        var worker = new ValidUniqueMatrice();
        var input = new[]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 2, 3 },
            new int[] { 1, 3, 2 }
        };

        var result = worker.CheckValid(input);
        var expected = false;
        
        Assert.Equal(expected, result);
    }
}