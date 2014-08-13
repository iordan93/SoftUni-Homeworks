function calcCylinderVol(value) {
    return Math.PI * value[0] * value[0] * value[1];
}
console.log(calcCylinderVol([2, 4]).toFixed(3));
console.log(calcCylinderVol([5, 8]).toFixed(3));
console.log(calcCylinderVol([12, 3]).toFixed(3));