/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersection = function(nums1, nums2) {
    let arr=[]
    nums1.forEach((item1)=>{
        nums2.forEach((item2)=>{
            if(item1===item2){
                arr=[...arr,item1]
            }
        })
    })
    return [...new Set(arr)]
};