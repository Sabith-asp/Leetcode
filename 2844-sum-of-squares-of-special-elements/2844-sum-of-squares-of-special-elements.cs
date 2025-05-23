public class Solution {
    public int SumOfSquares(int[] nums) {
        int n=nums.Length;
        int result=0;
        for(int i=1;i<=n;i++){
            if(n%i==0){
                result+=nums[i - 1] * nums[i - 1];
            }
        }
        return result;
    }
}