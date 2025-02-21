public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        List<int> numbers=nums.ToList();
        for(int i=0;i<nums.Length;i++){
            var strnum=nums[i].ToString().ToCharArray();
            Array.Reverse(strnum);
            int reversed=int.Parse(new string(strnum));
            Console.WriteLine(reversed);
            numbers.Add(reversed);
        }
    return numbers.Distinct().ToList().Count();
    }
}