/**
 * @param {string} s
 * @return {string[]}
 */
var printVertically = function(s) {
    let result=[]
    let split=s.split(" ")
    let max=Math.max(...split.map((item)=>item.length))
    let str=""
    for(i=0;i<max;i++){
        split.forEach((item)=>{if(item[i]===undefined){
            str+=" "
        }else {str+=item[i]}})
        result.push(str)
        str=""
    }
    return result.map((item)=>item.trimEnd())
};