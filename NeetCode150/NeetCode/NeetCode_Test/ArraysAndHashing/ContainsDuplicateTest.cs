namespace NeetCode_Test;
using Program;

public class ContainsDuplicateTest
{
    [Fact]
    public void ExampleTest1_Should_Be_True()
    {
        //Arrange
        var dup = new ContainsDuplicate();
        //Act
        int[] nums = {1,2,3,1};
        //Assert
        Assert.True(dup.ContainsDuplicate_method(nums));
    }

    [Fact]
    public void ExampleTest2_Should_Be_False()
    {
        //Arrange
        var dup = new ContainsDuplicate();
        //Act
        int[] nums = {1,2,3,4};
        //Assert
        Assert.False(dup.ContainsDuplicate_method(nums));
    }

    [Fact]
    public void ExampleTest3_Should_Be_True()
    {
        //Arrange
        var dup = new ContainsDuplicate();
        //Act
        int[] nums = {1,1,1,3,3,4,3,2,4,2};
        //Assert
        Assert.True(dup.ContainsDuplicate_method(nums));
    }
}