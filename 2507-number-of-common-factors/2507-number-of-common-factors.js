/**
 * @param {number} a
 * @param {number} b
 * @return {number}
 */
var commonFactors = function(a, b) {
    let res=[]
    for(i=1;i<=Math.max(a,b);i++){
        if(a%i==0 && b%i==0){
            res.push(i)
        }
    }
    return res.length
};