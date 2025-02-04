/**
 * @param {number[]} nums
 * @return {number}
 */
var maxAscendingSum = function(nums) {
    let arr=[]
    let sum=0
    for(i=0;i<nums.length;i++){
        
        if(nums[i+1]>nums[i]){
           sum=sum+nums[i]
        }else{
            arr.push(sum+nums[i])
            sum=0
        }
    }
    return Math.max(...arr)
};