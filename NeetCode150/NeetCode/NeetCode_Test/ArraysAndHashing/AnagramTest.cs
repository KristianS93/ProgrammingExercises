using Program;

namespace NeetCode_Test;

public class AnagramTest
{
    [Fact]
    public void ExampleTest1_should_be_true()
    {
        // Arrange
        var anagram = new Anagram();
        // Act
        var input1 = "anagram";
        var input2 = "nagaram";
        // Assert
        Assert.True(anagram.IsAnagram(input1, input2));
    }

    [Fact]
    public void ExampleTest1_should_be_false()
    {
        // Arrange
        var anagram = new Anagram();
        // Act
        var input1 = "rat";
        var input2 = "car";
        // Assert
        Assert.False(anagram.IsAnagram(input1, input2));
    }
    
    // [Fact]
    // public void FailedTest_should_be_fal
}