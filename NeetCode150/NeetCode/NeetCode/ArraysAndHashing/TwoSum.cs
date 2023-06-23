namespace Program;

public class TwoSum
{
    public int[] TwoSumMethod(int[] nums, int target)
    {
        // this is a clever solution only requiring a single run through the array
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            
            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }
            
            map[nums[i]] = i;
        }
        
        throw new ArgumentException("No two numbers add up to the target.");
    }
}