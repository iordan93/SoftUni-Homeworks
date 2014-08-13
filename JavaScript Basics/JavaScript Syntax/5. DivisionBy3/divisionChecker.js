function divisionBy3(value) {
    return value % 3 == 0;
}

function produceOutput(value) {
    console.log("The number " + value + " is " + (divisionBy3(value) ? "" : "not ") + "divided by 3 without remainder");
}

produceOutput(12);
produceOutput(188);
produceOutput(591);