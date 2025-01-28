public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int[] even=nums.Where(x=>x%2==0).ToList().ToArray();
        int[] odd=nums.Where(x=>x%2!=0).ToList().ToArray();
        
        return even.Concat(odd).ToArray();
    }
}