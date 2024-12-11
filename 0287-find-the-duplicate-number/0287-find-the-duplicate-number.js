/**
 * @param {number[]} nums
 * @return {number}
 */
var findDuplicate = function(nums) {
    const repeated={}
    for(const num of nums){
        repeated[num]=(repeated[num] || 0)+1
    }
    return Number(Object.keys(repeated).find((item)=>repeated[item]>1))
};