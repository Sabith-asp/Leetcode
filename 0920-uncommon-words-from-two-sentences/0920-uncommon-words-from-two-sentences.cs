public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        var data=s1+" "+s2;
        Console.WriteLine(data);
        return data.Split(' ').GroupBy(x=>x).Where(g=>g.Count()==1).Select(g=>g.Key).ToArray();

    }
}