document.addEventListener("DOMContentLoaded", function (e) {
    var numbers = [];
    for (var i = 1; i <= 10; i++) {
        numbers.push(i);
    }

    document.getElementById("numbers").innerHTML = numbers.join("<br />");
});