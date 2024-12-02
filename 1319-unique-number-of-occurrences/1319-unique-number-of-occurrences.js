/**
 * @param {number[]} arr
 * @return {boolean}
 */
var uniqueOccurrences = function(arr) {
    const matchCount={}
    for(const num of arr){
        matchCount[num]=(matchCount[num]+1 || 0)
    }
    return [...new Set(Object.values(matchCount))].length===Object.values(matchCount).length
};