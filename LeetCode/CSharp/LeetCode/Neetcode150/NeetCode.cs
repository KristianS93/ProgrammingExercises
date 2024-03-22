using System.Text.Json;
using System.Text.Json.Nodes;

namespace Neetcode150;

public class NeetCode
{
    public void Run()
    {
        Console.WriteLine(IsValid("(}")+ " - true");
        // var res = TwoSum(new int[] { 2,7,11,15 }, 9);
        // var str = JsonSerializer.Serialize(res);
        // Console.WriteLine(str);
    }
    public bool IsValid(string s)
    {
        // var stForward = new Stack<char>();
        // foreach (var el in s)
        // {
        //     stForward.Push(el);
        // } // ()[]{}

        var stBackward = new Stack<char>();
        var ss =s.Reverse();
        foreach (var el in ss)
        {
            stBackward.Push(el);
        }  // {}[]()

        var i = 0;
        while (stBackward.Count() > 0)
        {
            var bw = stBackward.Pop();
            if (s[i] - bw == 1 || s[i] - bw == -1)
            {
                return false;
            }

            i++;
        }

        return true;
    }
}