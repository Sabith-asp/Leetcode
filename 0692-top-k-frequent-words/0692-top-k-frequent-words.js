var topKFrequent = function(words, k) {
    let obj = {};

    words.forEach(word => {
        obj[word] = (obj[word] || 0) + 1;
    });

    let sortedWords = Object.keys(obj).sort((a, b) => {
        if (obj[a] === obj[b]) {
            return a.localeCompare(b);
        }
        return obj[b] - obj[a];
    });

    return sortedWords.slice(0, k);
};
