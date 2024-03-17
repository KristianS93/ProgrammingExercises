namespace LeetCode.Medium;

public class ContiguousArray
{
    public void Run()
    {
        // Console.WriteLine(FindMaxLength(new int[]{0,1})+ " should be 2");
        // Console.WriteLine(FindMaxLength(new int[]{0,1,0})+ " should be 2");
        // Console.WriteLine(FindMaxLength(new int[]{0,1,1}) + " should be 2");
        // Console.WriteLine(FindMaxLength(new int[]{0,1,0,1}) + " should be 4"); // 4
        // Console.WriteLine(FindMaxLength(new int[]{0,0,0,1,1,1,0}) + " should be 6"); // 6
        // Console.WriteLine(FindMaxLength(new int[]{0,0,1,0,0,0,1,1}) +  " should be 6"); // 6
        Console.WriteLine(FindMaxLength(new int[]{0,1,1,0,1,1,1,0}) +  " should be 4"); // 4
        
    }
    public int FindMaxLength(int[] nums)
    {
        var sumtable = new Dictionary<int, int>();
        var sum = 0;
        var count = 0;
        sumtable[0] = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                sum++;
            }
            else
            {
                sum--;
            }
            if (sumtable.ContainsKey(sum))
            {
                Console.WriteLine("Count is " + count + " second part " + i + "-" + sumtable[sum]);
                count = Math.Max(count, i-sumtable[sum]);
                Console.WriteLine("new count: "+ count);
            }
            else
            {
                sumtable[sum] = i;
            }
        }

        return count;



        // var MaxSteps = 0;
        // var count = 0;
        // var CurrentSteps = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] == 1)
        //     {
        //         sum++;
        //     }
        //     else
        //     {
        //         sum--;
        //     }
        //
        //     CurrentSteps++;
        //
        //     if (sum == 0)
        //     {
        //         if (CurrentSteps > MaxSteps)
        //         {
        //             MaxSteps = CurrentSteps;
        //         }
        //
        //         count++;
        //         CurrentSteps = 0;
        //     }
        //     
        // }
        // return count * MaxSteps;
        // var sum = new int[nums.Length];
        // var curSum = 0;
        // for(int i = 0; i<nums.Length; i++){
        //     if(nums[i] == 1){
        //         curSum++;
        //         sum[i] = curSum;
        //     } else {
        //         curSum--;
        //         sum[i]=curSum;
        //     }
        // }
        //
        // var dict = new Dictionary<int, int>();
        //
        // foreach (var el in sum)
        // {
        //     if (dict.ContainsKey(el))
        //     {
        //         dict[el]++;
        //     }
        //     else
        //     {
        //         dict[el] = 1;
        //     }
        // }
        //
        // dict.Count(el => el.Value > 1);
        //
        // if (curSum == 0)
        // {
        //     return nums.Length;
        // }
        //
    }
}