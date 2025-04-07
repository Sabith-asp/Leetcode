public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
        int count=0;
        int j=1;
        for(int i=0;i<words.Length-1;i++){
            while(j<words.Length){
                var split=words[j].ToCharArray();
                Array.Reverse(split);
                var joined=string.Join("",split);
                if(words[i]==joined){
                    count++;
                }
                j++;
            }
            j=i+2;
        }
        return count;
    }
}