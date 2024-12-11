/**
 * @param {number} num
 * @return {number}
 */
var countDigits = function(num) {
    let count=0
    for(const number of String(num)){
        num % number===0 && count++
    }
    return count
};