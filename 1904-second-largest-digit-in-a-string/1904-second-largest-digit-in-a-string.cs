public class Solution {
    public int SecondHighest(string s) {
        List<int> res = new List<int>();
        
        foreach (char c in s.ToCharArray()) {
            if (int.TryParse(c.ToString(), out int number)) {
                res.Add(number);
            }
        }

        var distinctDigits = res.Distinct().OrderByDescending(x => x).ToList();

        if (distinctDigits.Count < 2) {
            return -1;
        }

        return distinctDigits[1]; 
    }
}
