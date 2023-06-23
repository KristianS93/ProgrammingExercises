using Program;

namespace NeetCode_Test;

public class TwoSumTest
{
    [Fact]
    public void ExampleTest1()
    {
        // Arrange
        var twosum = new TwoSum();
        // Act
        int[] nums = { 2,7,11,15};
        int target = 9;
        int[] expected = { 0, 1 };
        // Assert
        Assert.Equal(expected, twosum.TwoSumMethod(nums, target)); 
    } 
    [Fact]
    public void ExampleTest2()
    {
        // Arrange
        var twosum = new TwoSum();
        // Act
        int[] nums = { 3,2,4};
        int target = 6;
        int[] expected = { 1, 2 };
        // Assert
        Assert.Equal(expected, twosum.TwoSumMethod(nums, target)); 
    } 
    [Fact]
    public void ExampleTest3()
    {
        // Arrange
        var twosum = new TwoSum();
        // Act
        int[] nums = { 3,3};
        int target = 6;
        int[] expected = { 0,1 };
        // Assert
        Assert.Equal(expected, twosum.TwoSumMethod(nums, target)); 
    }

    [Fact]
    public void ExampleTest4()
    {
        // Arrange
        var twosum = new TwoSum();
        // Act
        int[] nums = { 3,2, 3 };
        int target = 6;
        int[] expected = { 0, 2 };
        // Assert
        Assert.Equal(expected, twosum.TwoSumMethod(nums, target)); 

    }

}