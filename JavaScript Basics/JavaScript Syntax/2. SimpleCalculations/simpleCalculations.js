function roundNumber(value) {
    return [Math.floor(value), Math.round(value)];
}

console.log(roundNumber(22.7).join("\r\n"));
console.log(roundNumber(12.3).join("\r\n"));
console.log(roundNumber(58.7).join("\r\n"));