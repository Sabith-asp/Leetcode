public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
       Array.Sort(nums);
       int oddindex=0;
       int evenindex=0;
        int[] odds=new int[nums.Length/2];
        int[] even=new int[nums.Length/2];
        odds=nums.Where(x=>x%2!=0).ToArray();
        even=nums.Where(x=>x%2==0).ToArray();
        for(int i=0;i<nums.Length;i++){
if(i%2!=0){
nums[i]=odds[oddindex];
oddindex++;
}else{
    nums[i]=even[evenindex];
    evenindex++;
}
        }
            return nums;
    }

}