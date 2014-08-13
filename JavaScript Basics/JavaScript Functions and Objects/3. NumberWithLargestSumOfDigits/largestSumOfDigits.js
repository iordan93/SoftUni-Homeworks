function findLargestBySumOfDigits(nums) {
    function sumDigits(number) {
        var numberAsString = '' + Math.abs(number);
        var sum = 0;

        for (var i in numberAsString) {
            sum += parseInt(numberAsString[i]);
        }

        return sum;
    }

    var maxSum = 0;
    var maxNumber = 0;
    var currentSum = 0;

    for (var i in nums) {
        currentSum = sumDigits(nums[i]);

        if (isNaN(currentSum)) {
            maxNumber = undefined;
            break;
        }

        if (maxSum < currentSum) {
            maxSum = currentSum;
            maxNumber = nums[i];
        }
    }

    return maxNumber;
}

console.log(findLargestBySumOfDigits([5, 10, 15, 111]));
console.log(findLargestBySumOfDigits([33, 44, -99, 0, 2]));
console.log(findLargestBySumOfDigits(['hello']));
console.log(findLargestBySumOfDigits([5, 3.3]));