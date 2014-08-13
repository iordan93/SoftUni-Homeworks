function displayProperties(value) {
        for (var i in document) {
            document.getElementById("result").innerHTML += i + "<br />";
        }
}

displayProperties();