using Program;

namespace NeetCode_Test;

public class GroupAnagramsTest
{
    [Fact]
    public void ExampleTest1()
    {
        // Arrange
        var group = new GroupAnagrams();
        var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        // Act
        string[][] expected =
        {
            new string[] { "bat" },
            new string[] { "nat", "tan" },
            new string[] { "ate", "eat", "tea" }
        };
        // Assert
        Assert.Equal(expected, group.GroupAnagramsMethod(strs));
    }
    [Fact]
    public void ExampleTest2()
    {
        // Arrange
        var group = new GroupAnagrams();
        var strs = new string[] { "" };
        // Act
        string[][] expected =
        {
            new string[] { "" },
        };
        // Assert
        Assert.Equal(expected, group.GroupAnagramsMethod(strs));
    }
    [Fact]
    public void ExampleTest3()
    {
        // Arrange
        var group = new GroupAnagrams();
        var strs = new string[] { "a" };
        // Act
        string[][] expected =
        {
            new string[] { "a" },
        };
        // Assert
        Assert.Equal(expected, group.GroupAnagramsMethod(strs));
    }
}