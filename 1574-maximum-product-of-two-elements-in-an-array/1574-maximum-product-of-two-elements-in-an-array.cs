public class Solution {
    public int MaxProduct(int[] nums) {
        int result=0;
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                var product=(nums[i]-1)*(nums[j]-1);
            if(product>result){
                result=product;
            }
        }
        }
        return result;
    }
}