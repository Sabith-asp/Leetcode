public class Solution {
    public bool DetectCapitalUse(string word) {
        List<int> letter=new List<int>();
        var chararr=word.ToCharArray();
        foreach(var i in chararr){
            if(i==char.ToUpper(i)){
                letter.Add(1);
            }else{
                letter.Add(0);
            }
        }
        return letter.Distinct().ToList().Count==1 ||(letter.Skip(1).Distinct().ToList().Count==1 && chararr[0]==char.ToUpper(chararr[0]));
    }
}