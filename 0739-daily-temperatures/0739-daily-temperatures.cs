public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {

        int n = temperatures.Length;
        int[] result = new int[n];

        for (int i = n - 2; i >= 0; i--) {
            int j = i + 1;

            while (j < n) {
                if (temperatures[i] < temperatures[j]) {
                    result[i] = j - i;
                    break;
                } else if (result[j] == 0) {
                    result[i] = 0;
                    break;
                } else {
                    j += result[j]; // skip ahead using previous result
                }
            }
        }

        return result;




        // int[] result=new int[temperatures.Length];
        // for(int i=0;i<temperatures.Length;i++){
        //     int j=i;
        //     bool greaterFound=false;
        //     while(j<temperatures.Length){
        //         if(temperatures[i]<temperatures[j]){
        //             result[i]=j-i;
        //             greaterFound=true;
        //             break;
        //         }
        //         j++;
        //     }
        //     if(!greaterFound){
        //         result[i]=0;
        //     }
        // }
        // return result;
    }
}