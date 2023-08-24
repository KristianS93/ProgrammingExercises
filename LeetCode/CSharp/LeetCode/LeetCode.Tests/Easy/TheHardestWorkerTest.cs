using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class TheHardestWorkerTest
{
    [Fact]
    public void SampleTest1()
    {
        var worker = new TheHardestWorker();
        var input = new []
        {
            new []{0,3}, 
            new []{2,5}, 
            new []{0,9}, 
            new []{1,15}
        };

        var result = worker.HardestWorker(0, input);
        var expected = 1;
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SampleTest2()
    {
        var worker = new TheHardestWorker();
        var input = new []
        {
            new []{1,1}, 
            new []{3,7}, 
            new []{2,12}, 
            new []{7,17}
        };

        var result = worker.HardestWorker(0, input);
        var expected = 3;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SampleTest3()
    {
        var worker = new TheHardestWorker();
        var input = new []
        {
            new []{0,10}, 
            new []{1,20}
        };

        var result = worker.HardestWorker(0, input);
        var expected = 0;
        
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void SampleTest4()
    {
        var worker = new TheHardestWorker();
        var input = new []
        {
            new []{36,3}, 
            new []{1,5},
            new []{12,8}, 
            new []{25,9},
            new []{53,11},
            new []{29,12},
            new []{52,14} 
        };

        var result = worker.HardestWorker(0, input);
        var expected = 12;
        
        Assert.Equal(expected, result);
    }
}