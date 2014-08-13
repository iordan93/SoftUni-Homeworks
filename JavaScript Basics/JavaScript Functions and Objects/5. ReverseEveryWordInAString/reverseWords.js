function reverseWordsInString(str) {
    var words = str.split(' ');
    for (var i in words) {
        words[i] = words[i].split('').reverse().join('');
    }

    return words.join(' ');
}


console.log(reverseWordsInString("Hello, how are you."));
console.log(reverseWordsInString("Life is pretty good, isn't it?"));