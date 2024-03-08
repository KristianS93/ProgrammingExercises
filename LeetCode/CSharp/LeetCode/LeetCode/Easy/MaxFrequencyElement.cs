namespace LeetCode.Easy;

public class MaxFrequencyElement
{
    public void Run()
    {
        var ex1 = new[] { 1, 2, 2, 3, 1, 4 };
        Console.WriteLine(MaxFrequencyElements(ex1));

        var ex2 = new[] { 1, 2, 3, 4, 5 };
        Console.WriteLine(MaxFrequencyElements(ex2));
    }
    public int MaxFrequencyElements(int[] nums)
    {
        var frequencyTable = new Dictionary<int, int>();
        foreach (var el in nums)
        {
            if (frequencyTable.ContainsKey(el))
            {
                frequencyTable[el] += 1;
            }
            else
            {
                frequencyTable.Add(el, 1);
            }
        }

        var max = frequencyTable.Max(i => i.Value);
        return frequencyTable.Count(i => i.Value == max)*max;
    }
}