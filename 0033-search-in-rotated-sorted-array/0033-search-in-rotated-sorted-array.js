/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function(nums, target) {

    // for(const num of nums){
 
    //         return nums.indexOf(target)
    // }
    for(i=0;i<nums.length;i++){
        if(nums[i]===target){
            return i
        } 
    }
    return -1
};