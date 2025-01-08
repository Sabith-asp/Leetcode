/**
 * @param {string[]} words
 * @return {string}
 */
var firstPalindrome = function(words) {
    return words.find((item)=>item.split("").reverse().join("")===item) ||""
};