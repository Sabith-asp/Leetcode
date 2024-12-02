/**
 * @param {string[]} names
 * @param {number[]} heights
 * @return {string[]}
 */
var sortPeople = function(names, heights) {
    let arr=[]
    for(i=0;i<names.length;i++){
    arr.push({name:names[i],height:heights[i]})
    }
    return arr.sort((a,b)=>b.height-a.height).map((person)=>person.name)
};