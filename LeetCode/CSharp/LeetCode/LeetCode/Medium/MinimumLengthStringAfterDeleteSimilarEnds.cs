namespace LeetCode.Medium;

public class MinimumLengthStringAfterDeleteSimilarEnds
{
    public void Run()
    {
        Console.WriteLine("should be 2 " + MinimumLength("ca"));
        Console.WriteLine("should be 0 " + MinimumLength("cabaabac"));
        Console.WriteLine("should be 3 " + MinimumLength("aabccabba"));
        Console.WriteLine("should be 1 " + MinimumLength("bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb"));
        Console.WriteLine("should be 0 " + MinimumLength("cabaabac"));

    }
    public int MinimumLength(string s) {
        // convert to array
        var i = 0;
        var j = s.Length - 1;
        while (s[i] == s[j] && i < j)
        {
            if (s[i + 1] == s[j] && i + 1 < j)
            {
                i++;
                continue;
            }

            if (s[i] == s[j - 1] && j-1 > i)
            {
                j--;
                continue;
            }
            i++;
            j--;
        }

        return (j+1)-i; // idea is from the base case of ca having i = 0, j = 1, 1+2 =3 - 1+1 = 2
    }
}