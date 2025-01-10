/**
 * @param {string} num
 * @return {string}
 */
var removeTrailingZeros = function(num) {
    num=num.split("")
    for(i=num.length-1;i>=0;i--){
        if(num[i]!="0"){
            break
        }
        num.pop()
    }
    return num.join("")
};