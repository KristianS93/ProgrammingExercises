namespace Program;

public class Program
{
    static void Main()
    {
        var anagram = new GroupAnagrams();
        var input1 = "nagaram";
        var input2 = "anagram";

        Console.WriteLine(anagram.IsAnagram(input1, input2));
    }
}