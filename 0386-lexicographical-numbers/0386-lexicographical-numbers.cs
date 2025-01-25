public class Solution {
    public IList<int> LexicalOrder(int n) {
        List<string> res=new List<string>();
        for(int i=1;i<=n;i++){
            res.Add(i.ToString());
        }
       return res.OrderBy(item=>item).Select(item=>int.Parse(item)).ToList();
    }
}