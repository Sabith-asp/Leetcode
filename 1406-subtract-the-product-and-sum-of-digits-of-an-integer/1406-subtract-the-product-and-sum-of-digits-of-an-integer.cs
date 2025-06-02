public class Solution {
    public int SubtractProductAndSum(int n) {
        int product=1;
        int sum=0;
        var split=n.ToString().ToCharArray();
        foreach(char i in split){
            int digit=i-'0';
            product*=digit;
            sum+=digit;
        }
        return product-sum;
    }
}