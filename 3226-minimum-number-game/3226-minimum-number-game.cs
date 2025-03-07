public class Solution {
    public int[] NumberGame(int[] nums) {
        List<int> numbers=nums.ToList();
        List<int> result=new List<int>();
        while(numbers.Count>0){
            int alice=numbers.Min();  
            numbers.Remove(alice);
            int bob=numbers.Min(); 
            numbers.Remove(bob);
            result.Add(bob);
            result.Add(alice);

        }
        return result.ToArray(); 

    }
}