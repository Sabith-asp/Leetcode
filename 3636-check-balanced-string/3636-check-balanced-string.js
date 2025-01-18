/**
 * @param {string} num
 * @return {boolean}
 */
var isBalanced = function(num) {
     num=num.split("").map(item=>Number(item))
        console.log(num)
        let odd=[]
        let even=[]
        for(i=0;i<num.length;i++){
            if(i%2==0){
                even.push(num[i])
            }else{
                odd.push(num[i])
            }
        }

        return odd.reduce((acc,curr)=>acc+curr)==even.reduce((acc,curr)=>acc+curr)
};