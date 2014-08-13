document.addEventListener("DOMContentLoaded", function (e) {
    var currentTime = new Date();
    document.getElementById("time").innerHTML = currentTime.getHours() + ":" + currentTime.getMinutes().padLeft(2, "0");
});

Number.prototype.padLeft = function (n, str) {
    return Array(n - String(this).length + 1).join(str || '0') + this;
}