using BenchmarkDotNet.Running;
using LeetCode.Easy;
using LeetCode.Medium;

namespace LeetCode;

public static class Program
{
    public static void Main()
    {
        // var x = new SameTree();
        // var t = new TreeNode2(1);
        // var t1 = new TreeNode2(2);
        // var t2 = new TreeNode2(3);
        // t.left = t1;
        // t.right = t2;
        //
        // var c = new TreeNode2(1);
        // var c1 = new TreeNode2(2);
        // var c2 = new TreeNode2(3);
        // c.left = c1;
        // c.right = c2;


        // Console.WriteLine(x.IsSameTree(t, c));

        var x = new EvenOddTree();
        x.Run();
    }
}