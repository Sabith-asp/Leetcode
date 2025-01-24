/**
 * @param {string} s
 * @return {string}
 */
var removeStars = function(s) {
    let res=[]
    for(const i of s){
        if(i==="*"){
            res.pop()
        }else{
            res.push(i)
        }
    }
    return res.join("")
};