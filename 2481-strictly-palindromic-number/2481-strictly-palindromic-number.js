/**
 * @param {number} n
 * @return {boolean}
 */
var isStrictlyPalindromic = function(n) {
    let a=[]
    for(i=2;i<=35;i++){
        a.push(n.toString(i))
    }
    return a.length===a.filter((item)=>item===item.split("").reverse().join()).length
};