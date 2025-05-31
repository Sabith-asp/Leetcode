public class Solution {
    public int DistributeCandies(int[] candyType) {
        List<int> res=candyType.Distinct().ToList();
        int nums=res.Count;
        int max=candyType.Length/2;
        if(nums<=max){
            return nums;
        }
        return max;
    }
}