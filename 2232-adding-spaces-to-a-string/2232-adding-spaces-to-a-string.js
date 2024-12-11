/**
 * @param {string} s
 * @param {number[]} spaces
 * @return {string}
 */
var addSpaces = function(s, spaces) {
    let arr=[]
    let start=0
    for(i=0;i<=spaces.length;i++){
        
        arr.push(s.slice(start,spaces[i]))
        start=spaces[i]
    }
    return arr.join(" ")
};