using System.Text;

namespace LeetCode.Easy;

// https://leetcode.com/problems/a-number-after-a-double-reversal/
public class DoubleReverse
{
    public bool IsSameAfterReversals(int num)
    {
        // any number below 10 is correct automatically
        // this rule only applies if leading zeros appear
        // we can rule this out by just checking the remainder
        // of this first modulo isnt 0.
        return num < 10 || num % 10 != 0;
    }
}