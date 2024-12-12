/**
 * @param {number[]} nums
 * @return {number[]}
 */
var smallerNumbersThanCurrent = function(nums) {
    let result=[]
    for(i=0;i<nums.length;i++){
        let count=0
        for(j=0;j<nums.length;j++){
            nums[i]>nums[j] && count++
        }
        result.push(count)
        count=0
        
    }
    return result
};