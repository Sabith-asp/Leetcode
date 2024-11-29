/**
 * @param {string[]} nums
 * @param {string} target
 * @return {number}
 */
var numOfPairs = function(nums, target) {
    let count=0
    for(i=0;i<nums.length;i++){
        for(j=0;j<nums.length;j++){
            if(i!==j && target===nums[i]+nums[j]){
                count++
            }
        }
    }
    return count
};