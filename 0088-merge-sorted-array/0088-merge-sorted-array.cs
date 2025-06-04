public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var res=nums1.Take(m).Concat(nums2.Take(n)).OrderBy(x=>x).ToArray();
        for(int i=0;i<res.Length;i++){
            nums1[i]=res[i];
        }
    }
}