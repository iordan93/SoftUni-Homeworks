document.addEventListener("DOMContentLoaded", function () {
    var nextId = 1;
    generateTableRow();

    function generateTableRow(e) {
        if (e) {
            e.preventDefault();
        }

        var wrapper = document.createElement("tr");
        wrapper.setAttribute("id", "item-" + nextId);
        nextId++;
        wrapper.innerHTML =
            "<td><input type=\"text\" name=\"firstNames[]\"></td>" +
                "<td><input type=\"text\" name=\"lastNames[]\"></td>" +
                "<td><input type=\"email\" name=\"emails[]\"></td>" +
                "<td><input type=\"number\" name=\"examScores[]\" min=\"0\"><button class=\"remove-item\">-</button></td>";
        document.querySelector("table tbody").appendChild(wrapper);
    }

    document.getElementById("add-item").onclick = generateTableRow;

    document.getElementById("exams-table").onclick = function(e) {
        e.preventDefault();
        if(e.target.className == "remove-item") {
            e.target.parentNode.parentNode.remove();
        }
    }
});