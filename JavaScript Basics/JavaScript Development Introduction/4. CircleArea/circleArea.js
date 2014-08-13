document.addEventListener("DOMContentLoaded", function (e) {
    var radii = [7, 1.5, 20];
    var html = "";
    for (var r in radii) {
        area = calcCircleArea(radii[r]);
        html += "r = " + r + "; area = " + area + "<br />";
    }

    document.getElementById("areas").innerHTML = html;
});

function calcCircleArea(r) {
    return Math.PI * r * r;
}