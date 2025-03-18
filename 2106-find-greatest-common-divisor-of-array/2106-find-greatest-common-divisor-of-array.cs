public class Solution {
    public int FindGCD(int[] nums) {
        int max=nums.Max();
        int min=nums.Min();
        int result=0;
        for(int i=min;i>0;i--){
            if(max%i==0 && min%i==0){
                result=i;
                break;
            }
        }
        return result;
    }
}