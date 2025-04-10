public class Solution {
    public int FindComplement(int num) {
    //    var arr= num.ToString().ToCharArray();
       var arr = Convert.ToString(num, 2).ToCharArray();
       for(int i=0;i<arr.Length;i++){

        if(arr[i]=='1'){
            arr[i]='0';
        }else{
            arr[i]='1';
        }
       }
       string flippedBinary = new string(arr);
        return Convert.ToInt32(flippedBinary, 2);
    }
}