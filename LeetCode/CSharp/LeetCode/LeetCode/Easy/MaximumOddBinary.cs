using System.Runtime.InteropServices.JavaScript;

namespace LeetCode.Easy;

public class MaximumOddBinary
{
    public MaximumOddBinary()
    {
        
    }

    public void Run()
    {
        Console.WriteLine(MaximumOddBinaryNumber("010"));
        Console.WriteLine(MaximumOddBinaryNumber("0101"));
    }
    
    public string MaximumOddBinaryNumber(string s)
    {
        var len = s.Length;
        var oneCounter = s.Count(c => c == '1');
        var result = string.Empty;
        result += new string('1', oneCounter - 1);
        result += new string('0', len - oneCounter);
        result += "1";

        return result;
    }
}