/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    let counts={}
    for(const num of nums){
        counts[num]=(counts[num]||0)+1
    }
    if(Object.values(counts).find((item)=>item>=2)){
        return true
    }
    return false
};