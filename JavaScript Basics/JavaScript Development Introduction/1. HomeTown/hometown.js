document.addEventListener("DOMContentLoaded", function (e) {
    document.getElementById("submit").onclick = function () {
        alert(document.getElementById("hometown").value);
    };
});