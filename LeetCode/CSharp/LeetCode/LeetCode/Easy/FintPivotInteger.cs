namespace LeetCode.Easy;

public class FintPivotInteger
{
    public void Run()
    {
        Console.WriteLine(PivotInteger(8));
        Console.WriteLine(PivotInteger(1));
        Console.WriteLine(PivotInteger(4));
    }
    public int PivotInteger(int n)
    {
        int i = 0, j = n-1;
        int lres = 0, rres = n;
        while (i <= n)
        {
            if (lres < rres)
            {
                lres += i;
                i++;
            } else if (lres > rres)
            {
                rres += j;
                j--;
            }
            else if (lres == rres && j - i == 1)
            {
                return j - i;
            }
            
        }

        return -1;
    }
}