/**
 * @param {string[]} word1
 * @param {string[]} word2
 * @return {boolean}
 */
var arrayStringsAreEqual = function(word1, word2) {
    let final1="",final2=""
    word1.forEach((word)=>final1+=word)
    word2.forEach((word)=>final2+=word)
    return final1==final2
};