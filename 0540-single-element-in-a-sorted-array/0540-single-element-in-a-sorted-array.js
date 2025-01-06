/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNonDuplicate = function(nums) {
    let obj={}
    for(const num of nums){
        obj[num]=(obj[num]||0)+1
    }
    return Number(Object.keys(obj).find((item)=>obj[item]===1))
};