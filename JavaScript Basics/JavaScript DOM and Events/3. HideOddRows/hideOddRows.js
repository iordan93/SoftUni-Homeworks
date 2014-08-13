(function () {
    var button = document.getElementById("btnHideOddRows");
    button.onclick = function () {
        var rows = document.getElementsByTagName("tr");
        for (var i = 0; i < rows.length; i += 2) {
            rows[i].style.display = "none";
        }
    };
})();