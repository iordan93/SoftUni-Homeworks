function findMostFreqWord(text) {
    var wordCount = {};
    var words = text.split(" ");
    for (var i in words) {
        var word = words[i];
        if (!wordCount[word]) {
            wordCount[word] = 0;
        }
        wordCount[word]++;
    }
    return wordCount;
}

function produceOutput(text) {
    var words = findMostFreqWord(text);
    for (var i in words) {
        console.log(i + ' -> ' + words[i] + ' times');
    }
}

console.log(produceOutput('in the middle of the night'));
console.log(produceOutput('Welcome to SoftUni. Welcome to Java. Welcome everyone.'));
console.log(produceOutput('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'));