/**
 * @param {number} n
 * @param {number} m
 * @return {number}
 */
var differenceOfSums = function(n, m) {
    let not=0,yes=0
    for(i=1;i<=n;i++){
        if(i%m===0){
            yes+=i
        }
        else{
            not+=i
        }
    }
    return not-yes
};