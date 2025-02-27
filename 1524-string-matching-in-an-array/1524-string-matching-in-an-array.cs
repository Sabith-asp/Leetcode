public class Solution {
    public IList<string> StringMatching(string[] words) {
        List<string> result=new List<string>();
        foreach(var word in words){
            foreach(var val in words){
                if(val.Contains(word) && val!=word){
                    result.Add(word);
                }
            }
        }
        return result.Distinct().ToList();
    }
}