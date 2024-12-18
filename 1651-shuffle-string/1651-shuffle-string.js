/**
 * @param {string} s
 * @param {number[]} indices
 * @return {string}
 */
var restoreString = function(s, indices) {
    const obj={}
    for(i=0;i<s.length;i++){
        obj[indices[i]]=s[i]
    }
    return Object.values(obj).join("")
};