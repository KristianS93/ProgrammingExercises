namespace LeetCode.AC;

public class CoinChange
{
    public void Run()
    {
        // Console.WriteLine(CoinChange1(12, new []{10, 6, 1}));
        // var x = CoinChange1(13, new []{10, 6, 1});
        // PrintCoins(x);
        Console.WriteLine(CoinChange2(13, new[] { 10, 6, 1 }));
        // CoinChange2(13, new[] { 10, 6, 1 });
        // PrintCoin2(13, new []{10, 6, 1});
    }

    private int[,] c = new int[4, 14];
    private bool[,] t = new bool[4, 14];

    public int[] CoinChange1(int A, int[] den)
    {
        // initialize C table, for ease of use we consider a list instead of array:
        var count = 0;
        for (int i = 0; i <= A; i++)
        {
            count++;
        }
        var c = new int[count];
        var t = new int[count];
        c[0] = 0;
        for (int a = 1; a <= A; a++)
        {
            var csub = int.MaxValue;
            var i = den.Length - 1;
            while (i > 0 && den[i] <= a)
            {
                if (c[a - den[i]] < csub)
                {
                    csub = c[a - den[i]];
                    t[a] = den[i];
                }
                i--;
            }
            c[a] = csub + 1;
        }
        return t;
    }

    public void PrintCoins(int[] t)
    {
        var a = t.Length - 1;
        while (a > 0)
        {
            Console.Write(t[a] + " ");
            a -= t[a];
        }
    }

    public int CoinChange2(int A, int[] den)
    {
        for (int i = 1; i < den.Length; i++)
        {
            for (int a = 0; a < A; a++)
            {
                c[i, a] = int.MaxValue;
                t[i, a] = false;
            }
        }
        return CoinChange2M(A, den, 1, A);
    }

    public int CoinChange2M(int A, int[] den, int i, int a)
    {
        if (c[i, a] == int.MaxValue)
        {
            if (i == den.Length - 1)
            {
                c[i, a] = a;
                t[i, a] = true;
            }
            else
            {
                c[i, a] = CoinChange2M(A, den, i + 1, a);
                var use = CoinChange2M(A, den, i, a - den[i]) + 1;
                if (use < c[i, a])
                {
                    c[i, a] = use;
                    t[i, a] = true;
                }
            }
        }
        return c[i, a];
    }

    public void PrintCoin2(int A, int[] den)
    {
        var a = A - 1;
        var i = 1;
        while (a > 0)
        {
            if (t[i, a])
            {
                Console.Write(den[i] + " ");
                a -= den[i];
            }
            else
            {
                i++;
            }
        }
    }
}