/**
 * @param {string} s
 * @return {number}
 */
var firstUniqChar = function(s) {
    let obj={}
    for(i=0;i<s.length;i++){
        obj[s[i]]=(obj[s[i]]||0)+1
    }
    return s.indexOf(Object.keys(obj).find(item=>obj[item]==1))
};