namespace LeetCode.Easy;

public class SquaresSortedArray
{
    public void Run()
    {
        int[] arr = new[] { -4, -1, 0, 3, 10 };
        var ar = SortedSquares(arr);
        foreach (var item in ar)
        {
            Console.Write(item + " ");   
        }

        Console.WriteLine();
        int[] arr2 = new[] { -7, -3, 2, 3, 11 };
        var ar2 = SortedSquares(arr2);
        foreach (var item in ar2)
        {
            Console.Write(item + " ");   
        }
    }
    public int[] SortedSquares(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] *= nums[i];
        }

        var val = nums.ToList();
        val.Sort();
        return val.ToArray();
    }
}