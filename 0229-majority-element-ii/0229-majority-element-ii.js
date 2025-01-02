/**
 * @param {number[]} nums
 * @return {number[]}
 */
var majorityElement = function(nums) {

    let obj={}
    for(const number of nums){
        obj[number]=(obj[number]||0)+1
    }
    return Object.keys(obj).filter((item)=>obj[item]>nums.length/3).map((item)=>Number(item))
};