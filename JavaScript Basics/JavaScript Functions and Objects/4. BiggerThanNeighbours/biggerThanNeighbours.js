function biggerThanNeighbours(index, arr) {
    var result;

    if (index === 0 || index === arr.length - 1) {
        result = "only one neighbor";
    } else if (index > arr.length - 1 || index < 0) {
        result = "invalid index";
    } else if (arr[index - 1] < arr[index] && arr[index] > arr[index + 1]) {
        result = "bigger";
    } else {
        result = "not bigger";
    }

    return result;
}

console.log(biggerThanNeighbours(2, [1, 2, 3, 3, 5]));
console.log(biggerThanNeighbours(2, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighbours(5, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighbours(0, [1, 2, 5, 3, 4]));