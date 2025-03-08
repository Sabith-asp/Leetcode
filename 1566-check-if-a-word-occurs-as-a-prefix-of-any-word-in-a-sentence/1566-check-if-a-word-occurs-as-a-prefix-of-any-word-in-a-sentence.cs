public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        string[] split=sentence.Split(" ");
        for(int i=0;i<split.Length;i++){
            if(split[i].StartsWith(searchWord)){
                return i+1;
            }
        }
        return -1;

    }
}