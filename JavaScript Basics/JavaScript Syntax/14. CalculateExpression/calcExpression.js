function calcExpression() {
    var input = document.getElementById("input");
    var result = eval(input.value).toString();
    document.getElementById("result").innerHTML = result;
}