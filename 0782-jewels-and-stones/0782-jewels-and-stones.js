/**
 * @param {string} jewels
 * @param {string} stones
 * @return {number}
 */
var numJewelsInStones = function(jewels, stones) {
    let split=jewels.split("")
    let count=0
    for(const letter of split){
        stones.split("").forEach((item)=>item===letter && count++)
    }
    return count
};