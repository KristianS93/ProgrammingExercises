using BenchmarkDotNet.Attributes;
using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class MostFrequentEvenElementTest
{
    [Fact]
    public void SampleTest1()
    {
        // Arrange
        var test = new MostFrequentEvenElement();
        var array = new[] {0,1,2,2,4,4,1};
        
        // Act
        var result = test.MostFrequentEven(array);
        var expected = 2;
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SampleTest2()
    {
        // Arrange
        var test = new MostFrequentEvenElement();
        var array = new[] {4,4,4,9,2,4};
        
        // Act
        var result = test.MostFrequentEven(array);
        var expected = 4;
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SampleTest3()
    {
        // Arrange
        var test = new MostFrequentEvenElement();
        var array = new[] {29,47,21,41,13,37,25,7};
        
        // Act
        var result = test.MostFrequentEven(array);
        var expected = -1;
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SampleTest4()
    {
        // Arrange
        var test = new MostFrequentEvenElement();
        var array = new[] {0, 0, 0, 0};
        
        // Act
        var result = test.MostFrequentEven(array);
        var expected = 0;
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SampleTest5()
    {
        // Arrange
        var test = new MostFrequentEvenElement();
        var array = new[] {8154,9139,8194,3346,5450,9190,133,8239,4606,8671,8412,6290};
        
        // Act
        var result = test.MostFrequentEven(array);
        var expected = 3346;
        
        // Assert
        Assert.Equal(expected, result);
    }
}
