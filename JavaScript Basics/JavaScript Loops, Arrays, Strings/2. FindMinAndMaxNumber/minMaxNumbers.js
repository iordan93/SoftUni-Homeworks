    function findMinMax(value) {
        var min = Math.min.apply(null, value);
        var max = Math.max.apply(null, value);
        return {
            min: min,
            max: max
        };
    }

    function produceOutput(value) {
        var minAndMax = findMinMax(value);
        console.log("Min -> " + minAndMax.min);
        console.log("Max -> " + minAndMax.max);
    }
    console.log(produceOutput([1, 2, 1, 15, 20, 5, 7, 31]));
    console.log(produceOutput([2, 2, 2, 2, 2]));
    console.log(produceOutput([500, 1, -23, 0, -300, 28, 35, 12]));
