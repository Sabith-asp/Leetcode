/**
 * @param {number} num
 * @return {boolean}
 */
var sumOfNumberAndReverse = function(num) {
    
    for(i=0;i<=num;i++){
        if(i+Number(String(i).split("").reverse().join(""))==num){
            return true
        }

    }
    return false
    
};