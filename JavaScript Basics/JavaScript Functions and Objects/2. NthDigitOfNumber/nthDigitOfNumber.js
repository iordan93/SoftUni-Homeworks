function findNthDigit(arr) {
    var position = arr[0];
    var number = ('' + arr[1]).replace(/[.-]+/g, '');

    var result = "The number doesn't have " + position + ' digits';

    if (position <= number.length) {
        result = number[number.length - position];
    }

    return result;
}

console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([6, 888.88]));