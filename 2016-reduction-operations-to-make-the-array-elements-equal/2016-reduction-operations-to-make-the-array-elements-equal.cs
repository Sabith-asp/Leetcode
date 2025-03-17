public class Solution {
    public int ReductionOperations(int[] nums) {
        Array.Sort(nums);
        int steps=0;
        int count=0;
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i]!=nums[i+1]){
                steps++;
            }
            count += steps;
        }
        return count;
    }
}