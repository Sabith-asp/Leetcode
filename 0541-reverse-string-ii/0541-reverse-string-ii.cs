public class Solution {
    public string ReverseStr(string s, int k) {
        char[] charArr = s.ToCharArray();

        for (int i = 0; i < charArr.Length; i += 2 * k) {
            int left = i;
            int right = Math.Min(i + k - 1, charArr.Length - 1);


            while (left < right) {
                (charArr[left], charArr[right]) = (charArr[right], charArr[left]);
                left++;
                right--;
            }
        }

        return new string(charArr);
    }
}
