

using BenchmarkDotNet.Attributes;

namespace LeetCode.Easy;

public class MostFrequentEvenElement
{
    public int MostFrequentEven(int[] nums)
    {
        var map = new Dictionary<int, int>();
        var maxFreq = 0;
        var res = -1;

        foreach (var num in nums)
        {
            if ((num ^ 1) == (num + 1))
            {
                // Explanation 
                // lets say num is 10 binary = 1010
                // we xor with 1 so
                // 1010
                // 0001
                // 1011 = 11 = num + 1 
                int freq = 1;

                if (!map.TryAdd(num, freq))
                {
                    freq = ++map[num];
                }

                if (freq > maxFreq || freq == maxFreq && res > num)
                {
                    (res, maxFreq) = (num, freq);
                }
            }
        }

        return res;
    }
}

[MemoryDiagnoser]
public class MemoryBenchMarker
{
    [Benchmark]
    public int MostFrequentEvenElement()
    {
        var test = new MostFrequentEvenElement();
        var array = new[] {29,47,21,41,13,37,25,7};

        return test.MostFrequentEven(array);
    }
}