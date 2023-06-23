namespace Program;

public class ContainsDuplicate
{
    public bool ContainsDuplicate_method(int[] nums)
    {
        var numbers = new HashSet<int>();
        foreach (var num in nums)
        {
            numbers.Add(num);
        }
        return nums.Length != numbers.Count;
    }
}