/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let count={}
    for(const num of nums){
        count[num]=(count[num] || 0)+ 1;
    }
    let largest=""
    for(const key of Object.keys(count)){
        if(count[key]>largest && count[key]>(nums.length/2)){
            largest=key
        }
    }
    return Number(largest)


};