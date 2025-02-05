public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if (s1.Length!=s2.Length) return false;
        List<int> list=new List<int>();
        for(int i=0;i<s1.Length;i++){
            if(s1[i]!=s2[i]){
                list.Add(i);
            }
            
        }
        if(list.Count==0) return true;
        if(list.Count==2){
            int j=list[0];
            int k=list[1];

            return s1[j]==s2[k] && s2[j]==s1[k];
        }
        return false;
    }
}