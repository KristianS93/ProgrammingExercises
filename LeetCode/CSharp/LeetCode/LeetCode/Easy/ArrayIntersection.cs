namespace LeetCode.Easy;

public class ArrayIntersection
{
    public void Run()
    {
        var ex1 = new int[] { 4,9,5 };
        var ex12 = new int[] { 9,4,9,8,4 };
        var res = Intersection(ex1, ex12);
        foreach (var el in res)
        {
            Console.Write(el + " ");
        }

        Console.WriteLine();
    }
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var hs = new HashSet<int>();
        var list = new List<int>();
        foreach (var el in nums1)
        {
            hs.Add(el);
        }

        foreach (var el in nums2)
        {
            if (hs.Contains(el) && !list.Contains(el))
            {
                list.Add(el);
            }
        }
        
        return list.ToArray();
    }
}