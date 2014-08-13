document.addEventListener("DOMContentLoaded", function () {
    var input = document.getElementById("numberInput");
    input.oninput = function () {
        if (/\D+/g.test(input.value)) {
            input.style.backgroundColor = "#ff0000";
            setTimeout(function () {
                input.style.backgroundColor = "#ffffff";
            }, 500);

            input.value = input.value.replace(/\D+/g, '');
        }
    }
}, false);