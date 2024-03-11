using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;

namespace LeetCode.Medium;

public class CustomSort
{
    public void Run()
    {
        var order = "cba";
        var s = "abcd";
        Console.WriteLine(CustomSortString(order, s));

        var order2 = "bcafg";
        var s2 = "abcd";
        Console.WriteLine(CustomSortString(order2, s2));
    }
    public string CustomSortString(string order, string s) {
        
    }
}