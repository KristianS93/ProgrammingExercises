using System.Text.Json;
using System.Text.Json.Nodes;

namespace Neetcode150;

public class NeetCode
{
    public void Run()
    {
        var res = TopKFrequent(new int[]{4,1,-1,2,-1,2,3}, 2);
        var str = JsonSerializer.Serialize(res);
        Console.WriteLine(str);
    }
    public int[] TopKFrequent(int[] nums, int k)
    {
        var ft = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (ft.ContainsKey(nums[i]))
            {
                ft[nums[i]]++;
            }
            else
            {
                ft.Add(nums[i], 1);
            }
        }

        var heap = new PriorityQueue<KeyValuePair<int, int>, int>();

        foreach (var kv in ft)
        {
            heap.Enqueue(kv, kv.Value);
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }

        var res = new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = heap.Dequeue().Key;
        }

        return res;
    }
}