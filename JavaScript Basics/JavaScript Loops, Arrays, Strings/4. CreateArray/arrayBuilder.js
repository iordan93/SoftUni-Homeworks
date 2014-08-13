function createArray(value) {
    var array = [];
    for (var i = 0; i < 20; i++) {
        array.push(i * 5);
    }

    return array;
}

console.log(createArray());