namespace LeetCode.Easy;

// https://leetcode.com/problems/check-if-every-row-and-column-contains-all-numbers/
public class ValidUniqueMatrice
{
    public bool CheckValid(int[][] matrix)
    {
        int j = 0;
        int k = 0;
        for (var i = 0; i < matrix.Length; i++)
        {
            // rows
            var rowCheck = new HashSet<int>();
            var colCheck = new HashSet<int>();
            for (; j < matrix.Length; j++, k++)
            {
                if (!rowCheck.Add(matrix[i][j]) || !colCheck.Add(matrix[k][i]))
                {
                    return false;
                }
            }
            j = 0;
            k = 0;
        }
        return true;
    }
}