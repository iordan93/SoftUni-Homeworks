function clockTick() {
    var angle = 360 / 60;
    var date = new Date();
    var hour = date.getHours();
    if (hour > 12) {
        hour = hour - 12;
    }
    var minute = date.getMinutes();
    var second = date.getSeconds();
    var hourAngle = (360 / 12) * hour + (360 / (12 * 60)) * minute;
    debugger;
    document.querySelector("#minute").style.webkitTransform = 'rotate(' + (angle * minute) + 'deg)';
    document.querySelector("#second").style.webkitTransform = 'rotate(' + (angle * second) + 'deg)';
    document.querySelector("#hour").style.webkitTransform = 'rotate(', hourAngle + 'deg)';
}