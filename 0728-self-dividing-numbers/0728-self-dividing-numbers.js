/**
 * @param {number} left
 * @param {number} right
 * @return {number[]}
 */
var selfDividingNumbers = function(left, right) {
    res=[]
    
    for(i=left;i<=right;i++){
        let selfdividing=true
        let spliti=String(i).split("").map(i=>Number(i))
        console.log(spliti)
       for(j=0;j<spliti.length;j++){
        if(i%spliti[j]!=0){
            selfdividing=false
            break
        }
       }
       if(selfdividing){
        res.push(i)
       }
    }
    return res
};