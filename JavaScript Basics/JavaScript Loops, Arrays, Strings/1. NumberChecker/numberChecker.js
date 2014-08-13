function numberChecker(n) {
    var numbers = [];
    for (var i = 1; i <= n; i++) {
        if ((i % 4 != 0) && (i % 5 != 0)) {
            numbers.push(i);
        }
    }

    return numbers.length > 0 ? numbers.join(", ") : "no";
}

console.log(numberChecker(20));
console.log(numberChecker(-5));
console.log(numberChecker(13));