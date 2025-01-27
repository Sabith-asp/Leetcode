public class Solution {
    public int AddDigits(int num) {
        char[] split=num.ToString().ToCharArray();
        while(split.Length>1){
            int j=0;
            for(int i=0;i<split.Length;i++){
                j=j+(split[i]-'0');
            }
            split=j.ToString().ToCharArray();
        }
        return int.Parse(split[0].ToString());
        
    }
}