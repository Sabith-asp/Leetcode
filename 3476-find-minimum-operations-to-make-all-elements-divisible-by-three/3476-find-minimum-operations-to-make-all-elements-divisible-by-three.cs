public class Solution {
    public int MinimumOperations(int[] nums) {
        int count=0;
        foreach(var i in nums){
            if(i%3!=0){
                count++;
            }
        }
        return count;
    }
}