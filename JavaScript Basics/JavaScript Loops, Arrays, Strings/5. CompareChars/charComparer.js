function compareChars(first, second) {
    var equal = true;

    if (first.length == second.length) {
        for (var i = 0; i < first.length; i++) {
            if (first[i] !== second[i]) {
                equal = false;
                break;
            }
        }
    } else {
        equal = false;
    }

    if (equal) {
        return "Equal";
    }
    else {
        return "Not Equal";
    }

}

console.log(compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']));
console.log(compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']));
console.log(compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']));

