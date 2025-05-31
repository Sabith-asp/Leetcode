public class Solution {
    public int DistributeCandies(int[] candyType) {
        List<int> res=candyType.ToList().Distinct().ToList();
        if(res.Count<=candyType.Length/2){
            return res.Count;
        }
        return candyType.Length/2;
    }
}