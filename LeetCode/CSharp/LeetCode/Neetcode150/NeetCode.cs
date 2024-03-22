using System.Text.Json;
using System.Text.Json.Nodes;

namespace Neetcode150;

public class NeetCode
{
    public void Run()
    {
        Console.WriteLine(Search(new int[]{-1,0,3,5,9,12}, 6));
        // var res = TwoSum(new int[] { 2,7,11,15 }, 9);
        // var str = JsonSerializer.Serialize(res);
        // Console.WriteLine(str);
    }
    public int Search(int[] nums, int target)
    {
        var end = nums.Length-1;
        var start = 0;
        var mid = 0;
        while (start <= end)
        {
            mid = (start + end) / 2;
            if (nums[mid] < target)
            {
                start = mid+1;
            } else if (nums[mid] > target)
            {
                end = mid-1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}