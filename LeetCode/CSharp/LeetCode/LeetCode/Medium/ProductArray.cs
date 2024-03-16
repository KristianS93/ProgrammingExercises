namespace LeetCode.Medium;

public class ProductArray
{
    public void Run()
    {
        var ex1 = new int[] { 1, 2, 3, 4 };
        var res1 = ProductExceptSelf(ex1);
        foreach (var el in res1)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine();
        
        var ex2 = new int[] { -1, 1, 0, -3, 3 };
        var res2 = ProductExceptSelf(ex2);
        foreach (var el in res2)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine();
    }
    public int[] ProductExceptSelf(int[] nums)
    {
        var length = nums.Length;
        var res = new int[length];

        var lp = 1;
        for (int i = 0; i < length; i++)
        {
            res[i] = lp;
            lp *= nums[i];
        }

        var rp = 1;
        for (int i = length - 1; i >= 0; i--)
        {
            res[i] *= rp;
            rp *= nums[i];
        }
        return res;
    }
}