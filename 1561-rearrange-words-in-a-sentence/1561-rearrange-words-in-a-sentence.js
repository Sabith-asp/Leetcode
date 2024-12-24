/**
 * @param {string} text
 * @return {string}
 */
var arrangeWords = function(text) {
    let res=text.split(" ").sort((a,b)=>a.length-b.length).join(" ")
    return res.slice(0,1).toUpperCase()+res.slice(1).toLowerCase()
};