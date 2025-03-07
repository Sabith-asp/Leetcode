public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max=candies.Max();
        List<bool> boolean=new List<bool>();
        foreach(var item in candies){
            if(item+extraCandies>=max){
                boolean.Add(true);
            }else{
                boolean.Add(false);
            }
        }
        return boolean;
    }
}