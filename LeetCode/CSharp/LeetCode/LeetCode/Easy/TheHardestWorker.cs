namespace LeetCode.Easy;
// https://leetcode.com/problems/the-employee-that-worked-on-the-longest-task/
public class TheHardestWorker
{
    public int HardestWorker(int n, int[][] logs)
    {
        int currentLongestWorker = -1;
        int currentStartTime = 0;
        int currentLongestTask = -1;
        foreach (var log in logs)              
        {
            if (log[1] - currentStartTime > currentLongestTask)
            {
                currentLongestWorker = log[0];
                currentLongestTask = log[1] - currentStartTime;
            } else if (log[1] - currentStartTime == currentLongestTask)
            {
                currentLongestWorker = Math.Min(currentLongestWorker, log[0]);
                
            }
            currentStartTime = log[1];
        }
        return currentLongestWorker;
    }
}