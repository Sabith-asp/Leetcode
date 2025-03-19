public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        int[] result=new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            nums[queries[i][1]]=nums[queries[i][1]]+queries[i][0];
            int value=0;
            foreach(var j in nums){
                
                if(j%2==0){
                    value+=j;
                }
            }
            result[i]=value;
            value=0;
        }
        return result;
    }
}