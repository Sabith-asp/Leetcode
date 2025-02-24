public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
        
        foreach (int num in nums) {
            if (DigitCount(num) % 2 == 0) {
                count++;
            }
        }
        
        return count;
    }

    private int DigitCount(int num) {
        return num.ToString().Length;
    }
}