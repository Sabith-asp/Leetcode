using System;

public class Solution {
    public string LongestWord(string[] words) {
        Array.Sort(words);
        List<string> validWords = new List<string>();
        string longestWord = "";

        foreach (string word in words) {
            if (word.Length == 1 || validWords.Contains(word.Substring(0, word.Length - 1))) {
                validWords.Add(word);
                if (word.Length > longestWord.Length) {
                    longestWord = word;
                }
            }
        }

        return longestWord;
    }
}
