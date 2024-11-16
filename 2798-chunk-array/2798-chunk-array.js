/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function(arr, size) {
    let result=[]
    for(i=0;i<arr.length;i=i+size){
        result=[...result,arr.slice(i,i+size)]
    }
    return result
};
