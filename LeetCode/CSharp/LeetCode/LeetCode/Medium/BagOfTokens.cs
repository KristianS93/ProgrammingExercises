namespace LeetCode.Medium;

public class BagOfTokens
{
    public void Run()
    {
        var ex1 = new []{ 100 };
        Console.WriteLine(BagOfTokensScore(ex1, 50));

        var ex2 = new[] { 200, 100 };
        Console.WriteLine(BagOfTokensScore(ex2, 150));

        var ex3 = new[] { 100, 200, 300, 400 };
        Console.WriteLine(BagOfTokensScore(ex3, 200));
    }
    public int BagOfTokensScore(int[] tokens, int power)
    {
        // First step sort
        // Array.Sort(tokens);
        var tokens2 = tokens.ToList();
        tokens2.Sort();
        // Initiate score
        var score = 0;
        
        // first pointer & second
        var i = 0;
        var j = tokens2.Count - 1;
        while (i <= j)
        {
            if (power >= tokens2[i]) // face_up count++
            {
                score++;
                power -= tokens2[i];
                i++;
            }
            else if (score > 0 && tokens2[i] != tokens2[j])
            {
                score--;
                power += tokens2[j];
                j--;
            }
            else
            {
                break;
            }
        }
        return score;
    }
}