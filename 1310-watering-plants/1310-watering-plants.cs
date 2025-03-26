public class Solution {
    public int WateringPlants(int[] plants, int capacity) {
        int steps=0;
        int originalcapacity=capacity;
        for(int i=0;i<plants.Length;i++){
            steps++;
            capacity=capacity-plants[i];
            if(i<plants.Length-1 && plants[i+1]>capacity){
                steps=steps+i+2+i;
                capacity=originalcapacity;
            }else{}
        }
        return steps;
    }
}