public class Solution {
    public int[] ShortestToChar(string s, char c) {
        int n = s.Length;
        int[] res = new int[n];
        int prev = int.MinValue / 2;  


        for (int i = 0; i < n; i++) {
            if (s[i] == c) {
                prev = i;
            }
            res[i] = i - prev;
        }

        prev = int.MaxValue / 2;  

        for (int i = n - 1; i >= 0; i--) {
            if (s[i] == c) {
                prev = i;
            }
            res[i] = Math.Min(res[i], prev - i);
        }

        return res;
    }
}
