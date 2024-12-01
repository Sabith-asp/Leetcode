var frequencySort = function(s) {
    const frequencyMap = {};
    for (let char of s) {
        frequencyMap[char] = (frequencyMap[char] || 0) + 1;
    }

    const result = Object.keys(frequencyMap)
        .sort((a, b) => frequencyMap[b] - frequencyMap[a]) 
        .map(char => char.repeat(frequencyMap[char]))     
        .join("");                                        

    return result;
};
