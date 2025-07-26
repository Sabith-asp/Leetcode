public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck); 
        List<int> result=new List<int>();

        for(int i=deck.Length-1;i>=0;i--){
            if (result.Count > 0)
            {
                int last = result[result.Count - 1];
                result.RemoveAt(result.Count - 1);
                result.Insert(0, last);
            }

            result.Insert(0,deck[i]);
        }
        return result.ToArray();

    }
}