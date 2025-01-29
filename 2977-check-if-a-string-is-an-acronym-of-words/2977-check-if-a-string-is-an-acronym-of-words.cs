

public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        if (words.Count != s.Length) return false;

        StringBuilder acronym = new StringBuilder();
        foreach (string word in words) {
            acronym.Append(word[0]);
        }

        return acronym.ToString() == s;
    }
}
