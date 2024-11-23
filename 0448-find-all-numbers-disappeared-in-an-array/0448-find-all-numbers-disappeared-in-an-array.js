/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDisappearedNumbers = function(nums) {
    let res=[]
    let sets=new Set(nums)
    for(i=1;i<=nums.length;i++){
       if(!sets.has(i)){
           res.push(i)
       }
    }
    return res
};