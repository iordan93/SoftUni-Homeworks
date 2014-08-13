document.addEventListener("DOMContentLoaded", function () {
    var liked = false;

    var button = document.getElementById("likeButton");
    displayButton(button, liked);
    button.onclick = function () {
        liked = !liked;
        displayButton(this, liked);
    };
}, false);

function displayButton(button, liked) {
    if (liked) {
        button.innerHTML = "Unlike";
    }
    else {
        button.innerHTML = "Like";
    }
}