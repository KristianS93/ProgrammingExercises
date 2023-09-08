namespace LeetCode.Easy.DynamicProgramming;

public class ClimbingStairs
{
    public int ClimbStairs(int n)
    {
        var oneStep = 1;
        var twoStep = 1;
        
        // 0 1 2 3 4 5 
        for (int i = n - 1; i > 0; i--)
        {
            var temp = oneStep;
            oneStep = oneStep + twoStep;
            twoStep = temp;
        }

        return oneStep;
    }
}