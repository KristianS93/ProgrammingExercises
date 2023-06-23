namespace Program;

public class Program
{
    static void Main()
    {
        var anagram = new Anagram();
        var input1 = "aacc";
        var input2 = "ccac";

        Console.WriteLine(anagram.IsAnagram(input1, input2));
    }
}