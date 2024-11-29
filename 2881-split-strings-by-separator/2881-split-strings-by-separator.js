/**
 * @param {string[]} words
 * @param {character} separator
 * @return {string[]}
 */
var splitWordsBySeparator = function(words, separator) {
    return words.map((item)=>item.split(`${separator}`)).flat().filter((item)=>item.length>0)
};