/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDuplicates = function(nums) {
    let counts={}
    for(const num of nums){
        counts[num]=(counts[num] || 0)+1
    }
    return Object.keys(counts).filter((item)=>counts[item]===2).map((item)=>Number(item))
};