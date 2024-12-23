/**
 * @param {string} s
 * @return {string}
 */
var sortVowels = function(s) {
    let elements=[]
    let index=[]
    let split=s.split("")
    for(i=0;i<s.length;i++){
        if(s[i].toLowerCase()==="a" ||s[i].toLowerCase()==="e"||s[i].toLowerCase()==="i"||s[i].toLowerCase()==="o"||s[i].toLowerCase()==="u"){
            elements.push(s[i])
            index.push(i)
        }
    }
    let sorted=elements.sort()
    for(j=0;j<index.length;j++){
        split.splice(index[j],1,sorted[j])
    }
    return split.join("")
    
};