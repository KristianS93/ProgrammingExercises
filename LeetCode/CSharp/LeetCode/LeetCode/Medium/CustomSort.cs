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

        var order3 = "kqep";
        var s3 = "pekeq";
        Console.WriteLine(CustomSortString(order3, s3));
    }
    public string CustomSortString(string order, string s) {
        var result = "";
        var ft = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (ft.ContainsKey(c))
            {
                ft[c] += 1;
            }
            else
            {
                ft.Add(c, 1);
            }
        }

        foreach (var c in order)
        {
            if (s.Contains(c))
            {
                result += new string(c, ft[c]);
                ft[c] = 0;
                s.Remove(c);
            }
        }
        
        

        // foreach (var c in order)
        // {
        //     if (ft.ContainsKey(c))
        //     {
        //         result += new string(c, ft[c]);
        //         // s = s.Remove(c);
        //     }
        // }
        
        return result;
    }
}