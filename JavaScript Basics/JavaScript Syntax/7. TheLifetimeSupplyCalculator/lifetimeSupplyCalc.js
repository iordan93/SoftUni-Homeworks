// Note: If you want to use the function without the array, its signature must be calcSupply()
// and instead of value, it must return the arguments array
function calcSupply(value) {
    return (value[1] - value[0]) * 365 * value[3];
}

function produceOutput(value) {
    console.log(calcSupply(value) + "kg of " + value[2] + " would be enough until I am " + value[1] + " years old.");
}

produceOutput([38, 118, "chocolate", 0.5]);
produceOutput([20, 87, "fruits", 2]);
produceOutput([16, 102, "nuts", 1.1]);