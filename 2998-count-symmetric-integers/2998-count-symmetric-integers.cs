public class Solution {
    public int CountSymmetricIntegers(int low, int high) {
        int count = 0;

        for (int i = low; i <= high; i++) {
            string numStr = i.ToString();
            int len = numStr.Length;

            if (len % 2 == 0) {
                int mid = len / 2;
                int sum1 = 0, sum2 = 0;

                for (int j = 0; j < mid; j++) {
                    sum1 += numStr[j] - '0';
                }

                for (int j = mid; j < len; j++) {
                    sum2 += numStr[j] - '0';
                }

                if (sum1 == sum2) {
                    count++;
                }
            }
        }

        return count;
    }
}
