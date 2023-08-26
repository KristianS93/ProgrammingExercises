namespace LeetCode.Easy;

public class PowerOfTwo
{
    public bool IsPowerOfTwo(int n)
    {

        // if n >= 1 this handles when n < 1 and then we logical and 
        // the n and n-1 as this works in binary. 
        // another solution could be 
        // return n == 1 || 1 << (int)Math.Log2(n) == n;
        // however here we dont need to do any heavy math.
        // which is why we choose this.
        return n >= 1 && (n & (n - 1)) == 0;
    }
}