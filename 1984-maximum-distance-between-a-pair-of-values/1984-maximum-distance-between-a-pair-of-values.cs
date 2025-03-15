public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int max = 0;
        int j = 0;

        for (int i = 0; i < nums1.Length; i++) {
            while (j < nums2.Length && nums1[i] <= nums2[j]) {
                j++; 
            }
            max = Math.Max(max, j - 1 - i);
        }

        return max;
    }
}
