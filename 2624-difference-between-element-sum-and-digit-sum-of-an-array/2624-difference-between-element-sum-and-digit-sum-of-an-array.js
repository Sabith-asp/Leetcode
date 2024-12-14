/**
 * @param {number[]} nums
 * @return {number}
 */
var differenceOfSum = function(nums) {
     return nums.reduce((acc,curr)=>acc+curr)- nums.map((item)=>{return String(item).split("")}).flat().reduce((acc,curr)=>acc+Number(curr),0)
};