public class Solution {
    public int CountPartitions(int[] nums) {
        int count=0;
        for(int i=0;i<nums.Length-1;i++){
            var diff=nums[0..(i+1)].Sum()-nums[(i+1)..nums.Length].Sum();
            Console.WriteLine(diff);
            if(diff%2==0){
                count++;
            }
        }
        return count;
    }
}