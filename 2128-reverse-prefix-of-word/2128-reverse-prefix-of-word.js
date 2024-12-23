/**
 * @param {string} word
 * @param {character} ch
 * @return {string}
 */
var reversePrefix = function(word, ch) {
    let index=word.indexOf(ch)+1
    return word.split("").slice(0,index).reverse().join("")+word.slice(index)
};