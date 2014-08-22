document.addEventListener("DOMContentLoaded", function () {
    var linksWithTooltips = document.querySelectorAll(".master-tooltip");
    [].forEach.call(linksWithTooltips, function (link) {
        link.addEventListener("mouseover", function () {
            var tooltip = document.createElement("div");
            tooltip.className = "tooltip";
            tooltip.innerHTML = this.getAttribute("data-tooltip");
            tooltip.style.display = "block";
            document.body.appendChild(tooltip);
        });
        link.addEventListener("mouseout", function () {
            var toolitps = document.querySelectorAll(".tooltip");
            [].forEach.call(toolitps, function (tooltip) {
                tooltip.remove();
            });
        });
        link.addEventListener("mousemove", function (e) {
            var tooltip = document.querySelector(".tooltip");
            tooltip.style.top = (e.pageY + 20) + "px";
            tooltip.style.left = (e.pageX + 10) + "px";
        });
    });
});