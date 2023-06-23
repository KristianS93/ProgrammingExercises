namespace Program;

public class Anagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var map = new Dictionary<char, int>();
        foreach (var character in s)
        {
            if (map.ContainsKey(character))
            {
                map[character]++;

            }
            else
            {
                map.Add(character, 1);
            }
        }
        // another comment
        // another solution could be to insert or count up the value in 2 
        // separate maps at the same time, and then cross check and short
        // circuit if the values doesnt match for the key. 
        foreach (var character in t)
        {
            if (map.ContainsKey(character))
            {
                map[character]--;
            }
        }
        
        return map.Values.Max() == 0;
    }
}