public class Solution {
    public int FindComplement(int num) {
        Console.WriteLine(Convert.ToString(num,2));
        char[] split=Convert.ToString(num,2).ToCharArray();
        for(int i=0;i<split.Length;i++){
            if(split[i]=='0'){
                split[i]='1';
            }else{
                split[i]='0';
            }
        }
    // Console.WriteLine(int.Parse(string.Join("",split)));

       return Convert.ToInt32(string.Join("", split), 2);
    }
}