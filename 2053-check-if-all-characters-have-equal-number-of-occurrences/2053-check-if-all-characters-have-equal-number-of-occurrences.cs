public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var dict=new Dictionary<char,int>();
        foreach(char i in s){
            if(dict.ContainsKey(i)){
                dict[i]++;
            }else{
                dict[i]=1;
            }
        }
        int expectedCount = dict.Values.First();

        foreach (var count in dict.Values) {
            if (count != expectedCount) {
                return false;
            }
        }

        return true;
    }
}