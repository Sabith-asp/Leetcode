/**
 * @param {number[]} heights
 * @return {number}
 */
var heightChecker = function(heights) {
    let count = 0;
    let original = [...heights];
    let sorted = [...heights].sort((a, b) => a - b); 

    for (let i = 0; i < heights.length; i++) {
        if (original[i] !== sorted[i]) {
            count++;
        }
    }
    return count;
};
