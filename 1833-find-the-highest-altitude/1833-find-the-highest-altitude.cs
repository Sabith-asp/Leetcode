public class Solution {
    public int LargestAltitude(int[] gain) {
        List<int> alts=new List<int>();
        int prev=0;
        alts.Add(0);
        for(int i=0;i<gain.Length;i++){
            alts.Add(prev+gain[i]);
            prev=alts[i+1];
        }
        return alts.Max(x=>x);
    }
}