var squares = [];
var score;
var moves;
var turn = "X";
var wins = [7, 56, 448, 73, 146, 292, 273, 84];

startNewGame = function () {
    var i;

    turn = "X";
    score = { "X": 0, "O": 0 };
    moves = 0;
    for (i = 0; i < squares.length; i++) {
        squares[i].firstChild.nodeValue = "";
    }
},

win = function (score) {
    var i;
    for (i = 0; i < wins.length; i++) {
        if ((wins[i] & score) === wins[i]) {
            return true;
        }
    }
    return false;
},

set = function () {
    if (this.firstChild.nodeValue !== "") {
        return;
    }
    this.firstChild.nodeValue = turn;
    moves += 1;
    score[turn] += this.indicator;
    if (win(score[turn])) {
        alert(turn + " wins!");
        startNewGame();
    } else if (moves == 9) {
        alert("Draw!");
        startNewGame();
    } else {
        turn = turn === "X" ? "O" : "X";
    }
},

playGame = function () {
    var board = document.createElement("table"),
        indicator = 1,
        i, j,
        row, cell,
        parent;
    board.border = 1;
    for (i = 0; i < 3; i++) {
        row = document.createElement("tr");
        board.appendChild(row);
        for (j = 0; j < 3; j++) {
            cell = document.createElement("td");
            cell.width = cell.height = 50;
            cell.align = cell.valign = 'center';
            cell.indicator = indicator;
            cell.onclick = set;
            cell.appendChild(document.createTextNode(""));
            row.appendChild(cell);
            squares.push(cell);
            indicator += indicator;
        }
    }

    parent = document.getElementById("tictactoe") || document.body;
    parent.appendChild(board);
    startNewGame();
};

document.addEventListener("DOMContentLoaded", function (e) {
    playGame();
});
