/**
 * @param {number[]} nums
 * @return {number[]}
 */
var rearrangeArray = function(nums) {
    let positive=[]
    let negative=[]
    let result=[]
    nums.forEach((item)=> item>0 ? positive.push(item) : negative.push(item))
    for(i=0;i<positive.length;i++){
        result.push(positive[i])
        result.push(negative[i])
    }
    return result
};