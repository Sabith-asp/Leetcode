/**
 * @param {string[]} dictionary
 * @param {string} sentence
 * @return {string}
 */
var replaceWords = function(dictionary, sentence) {
    let split=sentence.split(" ")
    // let result=[]
    for(i=0;i<dictionary.length;i++){
        split=split.map((item)=>{
            if(item.slice(0,dictionary[i].length).includes(dictionary[i])){
                return dictionary[i]
            }return item
        })
    }
    return split.join(" ")
};