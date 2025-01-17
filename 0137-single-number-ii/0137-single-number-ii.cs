using System.Linq;

public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (var num in nums) {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }


        return counts.FirstOrDefault(kvp => kvp.Value == 1).Key;
    }
}
